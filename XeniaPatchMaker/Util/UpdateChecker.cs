using Octokit;
using Semver;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace XeniaPatchMaker
{
    public enum UpdateType
    {
        None,
        Major,
        Minor,
        Patch
    }

    public class UpdateChecker
    {
        private IReleasesClient _releaseClient;
        internal GitHubClient GitHub;

        internal SemVersion CurrentVersion;
        internal string RepositoryOwner;
        internal string RepositoryName;
        internal Release LatestRelease;

        void Init(string owner, string name, SemVersion version)
        {
            GitHub = new GitHubClient(new ProductHeaderValue(name + @"-UpdateCheck"));
            _releaseClient = GitHub.Repository.Release;

            RepositoryOwner = owner;
            RepositoryName = name;
            CurrentVersion = version;
        }

        public UpdateChecker(string owner, string name)
        {
            Helper.ArgumentNotNullOrEmptyString(owner, @"owner");
            Helper.ArgumentNotNullOrEmptyString(name, @"name");

            string version = System.Windows.Forms.Application.ProductVersion;

            version = version.Substring(0, version.LastIndexOf('.'));

            Init(owner, name, version);
        }

        public UpdateChecker(string owner, string name, string version)
        {
            Helper.ArgumentNotNullOrEmptyString(owner, @"owner");
            Helper.ArgumentNotNullOrEmptyString(name, @"name");
            Helper.ArgumentNotNullOrEmptyString(version, @"version");

            Init(owner, name, Helper.StripInitialV(version));
        }

        public async Task<UpdateType> CheckUpdate(UpdateType locked = UpdateType.None)
        {
            var releases = await _releaseClient.GetAll(RepositoryOwner, RepositoryName);

            SemVersion lockedVersion;
            switch (locked)
            {
                case UpdateType.Major:
                    lockedVersion = new SemVersion(CurrentVersion.Major + 1);
                    LatestRelease = releases.FirstOrDefault(
                        release => !release.Prerelease &&
                        Helper.StripInitialV(release.TagName) > CurrentVersion &&
                        Helper.StripInitialV(release.TagName) < lockedVersion
                    );
                    break;
                case UpdateType.Minor:
                    lockedVersion = new SemVersion(CurrentVersion.Major, CurrentVersion.Minor + 1);
                    LatestRelease = releases.FirstOrDefault(
                        release => !release.Prerelease &&
                        Helper.StripInitialV(release.TagName) > CurrentVersion &&
                        Helper.StripInitialV(release.TagName) < lockedVersion
                    );
                    break;
                default:
                    LatestRelease = releases.FirstOrDefault(
                        release => !release.Prerelease &&
                        Helper.StripInitialV(release.TagName) > CurrentVersion
                    );
                    break;
            }

            if (LatestRelease == null) return UpdateType.None;

            var tagName = LatestRelease.TagName;
            var latestVersion = Helper.StripInitialV(tagName);

            if (latestVersion.Major != CurrentVersion.Major)
                return UpdateType.Major;
            if (latestVersion.Minor != CurrentVersion.Minor)
                return UpdateType.Minor;
            if (latestVersion.Patch != CurrentVersion.Patch)
                return UpdateType.Patch;

            return UpdateType.None;
        }

        public async Task<string> RenderReleaseNotes()
        {
            if (LatestRelease == null)
                throw new InvalidOperationException();

            return await GitHub.Miscellaneous.RenderRawMarkdown(LatestRelease.Body);
        }

        public /*async*/ void DownloadAsset(string Assetname)
        {
            // asset.Url is some api wizardry that we'll maybe use later
            //var assets = await _releaseClient.GetAssets(RepositoryOwner, RepositoryName, LatestRelease.Id);
            //var asset = assets.First(n => n.Name == asset name);
            // For now, do some ugly shit
            var url = string.Format("https://github.com/{0}/{1}/releases/download/{2}/{3}", RepositoryOwner, RepositoryName, LatestRelease.TagName, Assetname);
            using (var client = new WebClient())
            {
                client.DownloadFile(url, "XeniaPatchMakerUpdate.exe");
            }
        }
    }
}
