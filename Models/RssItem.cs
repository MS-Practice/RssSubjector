using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RssSubjector.Models
{
    public class RssItem
    {
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("link")]
        public string Link { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("category")]
        public List<string> Categories { get; set; }
        [XmlIgnore]
        public Guid Guid { get; set; }
        [XmlElement("guid")]
        public string GuidString {
            get {
                return this.Guid.ToString();
            }
            set {
                this.Guid = Guid.Parse(value);
            }
        }
        [XmlIgnore]
        public DateTime PubDate { get; set; }
        [XmlElement("pubDate")]
        public string PubDateString
        {
            get
            {
                return this.PubDate.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                this.PubDate = DateTime.Parse(value);
            }
        }
    }
}