using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RssSubjector.Models
{
    [XmlRoot("channel")]
    public class RssChannel
    {
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("link")]
        public string Link { get; set; }
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
        [XmlElement("copyright")]
        public string Copyright { get; set; }
        [XmlElement("generator")]
        public string Generator { get; set; }
        [XmlElement("item")]
        public List<RssItem> Items { get; set; }
    }
}