using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XeniaPatchMaker.Util
{
    /// <summary>
    /// This is the format class that hold title information.
    /// </summary>
    [XmlRoot("SettingsDB")]
    public class SettingsDB : IXmlSerializable<SettingsDB>
    {
        /// <summary>
        /// The game titles dictionary.
        /// </summary>
        [XmlArray("titles")]
        [XmlArrayItem("title")]
        public List<SettingsEntry> Titles { get; set; } = new List<SettingsEntry>();

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public Encoding Encoding { get; set; } = Encoding.UTF8;

        /// <summary>
        /// Loads the <see cref="SettingsDB"/> XML file into memory.
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static SettingsDB XmlDeserialize(string xml)
        {
            SettingsDB result = new SettingsDB();
            try
            {
                var xmlSettings = new XmlReaderSettings { CheckCharacters = false };
                result = (SettingsDB)new XmlSerializer(typeof(SettingsDB)).Deserialize(XmlReader.Create(new MemoryStream(Encoding.Unicode.GetBytes(xml)), xmlSettings));
            }
            catch (Exception) { }
            return result;
        }

        /// <summary>
        /// Saves the <see cref="SettingsDB"/> to an XML file.
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="indentAttributes"></param>
        /// <returns></returns>
        public string XmlSerialize(bool indent = false, bool indentAttributes = false)
        {
            var result = string.Empty;
            try
            {
                var xmlSettings = new XmlWriterSettings
                {
                    Encoding = Encoding,
                    Indent = indent,
                    NewLineOnAttributes = indentAttributes,
                    NewLineHandling = NewLineHandling.Entitize,
                    IndentChars = "\t",
                    CheckCharacters = false
                };

                using (var sw = new StringWriter())
                {
                    var serializer = new XmlSerializer(typeof(SettingsDB));
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    serializer.Serialize(XmlWriter.Create(sw, xmlSettings), this, namespaces);

                    result = sw.ToString();
                }
            }
            catch (Exception) { throw; }
            return result;
        }
    }
}
