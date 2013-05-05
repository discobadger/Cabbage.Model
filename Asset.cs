using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Cabbage.Common;

namespace NMSI.MMX.API.Models
{
    public interface IAsset
    {
        string Uri { get; set; }
        string Id { get; set; }

        string Created { get; set; }
        string Creator { get; set; }
        string CreatorRole { get; set; }
        string CreditLine { get; set; }
        string Description { get; set; }
        string Identifier { get; set; }
        string RelatedAccessionNumber { get; set; }
        string Rights { get; set; }
        string Subject { get; set; }
        string Type { get; set; }

        IEnumerable<IImage> Images { get; set; }
    }

    public interface IAssetCompact
    {
        string Uri { get; set; }
        string Id { get; set; }
        string Description { get; set; }

        IEnumerable<IImage> Images { get; set; }
    }

    [KnownType("KnownTypes")]
    [DataContract]
    [RdfTypeAttribute(Identifier = "mmx:Asset")]
    public class Asset : NMSI.MMX.API.Models.IAsset
    {
        #region Linked Entities

        [DataMember]
        [RdfLinkedEntityAttribute(Predicate = "mmx:Image")]
        public IEnumerable<IImage> Images { get; set; }

        #endregion

        #region Properties

        [DataMember]
        [RdfSubjectAttribute(id = "Asset")]
        [RdfNameAttribute(Key = "Asset")]
        public string Uri { get; set; }

        [DataMember]
        [RdfNameAttribute(Key = "Id")]
        public string Id { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dcterms:type")]
        public string Type { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dcterms:identifier")]
        public string Identifier { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dcterms:description")]
        public string Description { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dcterms:created")]
        public string Created { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dcterms:subject")]
        public string Subject { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dc:rights")]
        public string Rights { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "dc:creator")]
        public string Creator { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "mmx:creatorRole")]
        public string CreatorRole { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "mmx:creditLine")]
        public string CreditLine { get; set; }

        [DataMember]
        [RdfPredicateAttribute(Predicate = "mmx:relatedAccessionNumber")]
        public string RelatedAccessionNumber { get; set; }

        #endregion

        public Asset()
        {
        }

        public Asset(bool mockMe)
        {
            if (mockMe)
            {
                MockMe();
            }
        }

        private void MockMe()
        {
            var MockImages = new List<NMSI.MMX.API.Models.IImage>();

            this.Uri = "http://data.sciencemuseum.org.uk/id/asset/smibbtl-12964";
            this.Id = "smibbtl-12964";
            this.Identifier = "a642932_(0001)";
            this.Rights = "This image is available for use under the following licence: Creative Commons Attribution-Non-Commercial-No Derivative Works 2.0 UK: England & Wales Licence";
            this.CreditLine = "Science Museum London";
            this.Creator = "Jaron Chubb";
            this.CreatorRole = "Photographer";
            this.Created = "2009:06:11 16:01:22+01:00";
            this.Description = "Tin glazed earthenware accouchement bowl and platter, decorated with scenes of childbirth, from Urbino, Italian, 16th century. Fill view of top of platter and bowl, graduated grey background.";

            var image = new Image();
            image.Uri = "http://placehold.it/182x275";
            image.Width = 182;
            image.Height = 275;
            image.Format = "image/gif";
            image.Role = "thumbnail";
            MockImages.Add(image);

            image = new Image();
            image.Uri = "http://placehold.it/255x384";
            image.Width = 255;
            image.Height = 384;
            image.Format = "image/gif";
            image.Role = "preferred";
            MockImages.Add(image);

            image = new Image();
            image.Uri = "http://placehold.it/511x768";
            image.Width = 511;
            image.Height = 768;
            image.Format = "image/gif";
            MockImages.Add(image);

            image = new Image();
            image.Uri = "http://placehold.it/1022x1536";
            image.Width = 1022;
            image.Height = 1536;
            image.Format = "image/gif";
            MockImages.Add(image);

            image = new Image();
            image.Uri = "http://www.sciencemuseum.org.uk/sop/zoom/13039.dzi";
            image.Format = "zoomable";
            MockImages.Add(image);

            this.Images = MockImages;
        }

        public static IEnumerable<Type> KnownTypes()
        {
            return new[] { typeof(mmxConnection), typeof(NMSI.MMX.API.Models.Asset), typeof(NMSI.MMX.API.Models.Image) };
        }
    }
}