using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Cabbage.Common;

namespace NMSI.MMX.API.Models
{
    public interface IImage
    {
        string Uri { get; set; }
        string Format { get; set; }

        int Height { get; set; }
        int Width { get; set; }

        string Role { get; set; }
    }

    [DataContract]
    [RdfTypeAttribute(Identifier = "mmx:Image")]
    public class Image : IImage
    {
        [DataMember]
        public string Uri { get; set; } // predicate?

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dcterms:format")]
        public string Format { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "mmx:height")]
        public int Height { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "mmx:width")]
        public int Width { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "mmx:role")]
        public string Role { get; set; }
    }
}

