using System.Drawing;
using System.Xml.Serialization;

namespace XeniaPatchMaker.Util
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingsEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("DisableDesc")]
        public bool DisableDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("DisableColors")]
        public bool DisableColors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("title")]
        public Color Title { get; set; }
    }
}
