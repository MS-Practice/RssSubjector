using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;

namespace RssSubjector.Models
{
    [XmlRoot(ElementName = "rss")]
    public class Rss
    {
        [XmlElement("channel")]
        public RssChannel Channel { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
