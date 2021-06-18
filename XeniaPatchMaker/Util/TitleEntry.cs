using System.Xml.Serialization;

namespace XeniaPatchMaker.Util
{
    /// <summary>
    /// 
    /// </summary>
    public class TitleEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("id")]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("title")]
        public string Title { get; set; }
    }
}
