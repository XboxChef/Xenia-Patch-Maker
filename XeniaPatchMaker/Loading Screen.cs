using DevExpress.XtraSplashScreen;
using System;

namespace XeniaPatchMaker
{
    public partial class Loading_Screen : SplashScreen
    {
        public Loading_Screen()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen1_Shown(object sender, EventArgs e)
        {

        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}