using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Cabbage.Common;

namespace NMSI.MMX.API.Models
{
    [DataContract(Namespace = "")]
    public class mmxConnection
    {
        [DataMember(IsRequired = false)]
        public string Uri; // MMX RDF Uri

        [DataMember(IsRequired = false)]
        public string Id; // ID part of the MMX RDF Uri

        [DataMember(IsRequired = false)]
        public string Title;

        [DataMember(IsRequired = false)]
        public string Description;

        [DataMember(IsRequired = false)]
        public string ImageUri;

        public mmxConnection()
        {
        }

        public mmxConnection(bool mockMe)
        {
            if(mockMe)
                MockMe();
        }

        private void MockMe()
        {
            this.Uri = BaseUrl.Object + "SMXG-1234";
            this.Id = "SMXG-1234";

            this.Title = "Mocked Object Title";
            this.Description = "Mocked object description";

            this.ImageUri = "http://placehold.it/89x128";
        }
    }
}