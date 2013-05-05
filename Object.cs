using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization;
using Cabbage.Common;

namespace NMSI.MMX.API.Models
{
    /// <summary>
    /// Single object container
    /// </summary>
    [KnownType("KnownTypes")]
    [DataContract]
    [RdfTypeAttribute(Identifier = "mmx:Object")]
    public sealed class Object : NMSI.MMX.API.Models.IObject
    {
        public Object()
        {
        }

        public Object(bool mockMe)
        {
            if (mockMe)
            {
                MockMe();
            }
        }

        private void MockMe()
        {
            //Random random = new Random();
            //int randomNumber = random.Next(1, 10000);

            Uri = BaseUrl.Object + "SMXG-1234";
            AccessionNumber = "STUB001";

            Title = "Babbage's Analytical Engine, 1834-1871. (Trial model)";
            DescriptiveTitle = "analytical engines";
            Materials = "various metals, steel, brass, bronze etc";
            Description = "Analytical engine constructed by the late Chas. Babbage, F.R.S., (this was not put together when received and there are still many pieces, moulds etc. received in 1878, on exhibition in the gallery)";
            ExtendedDescription = "It was first described in 1837 as the successor to Babbage's Difference engine, a design for a mechanical computer. The Analytical Engine incorporated an arithmetic logic unit, control flow in the form of conditional branching and loops, and integrated memory, making it the first design for a general-purpose computer that could be described in modern terms as Turing-complete.";
            Note = "Charles Babbage's calculating engines are among the most celebrated icons in the prehistory of computing. His Difference Engine No. 1 was the first successful automatic calculator and remains one of the finest examples of precision engineering of the time. The portion shown was assembled in 1832 by Babbage's engineer, Joseph Clement. It consists of about 2000 parts and represents one-seventh of the complete engine. This 'finished portion of the unfinished engine' was demonstrated to some acclaim by Babbage, and functions impeccably to this day. The engine was never completed and most of the 12 000 parts manufactured were later melted for scrap";
            CreditLine = "Major-General Babbage";

            LocationText = "Science Museum, Computing Gallery";
            CollectionName = "SCM - Computing & Data Processing";

            DateText = "1871";
            EaliestDate = "1871";
            LatestDate = "1871";

            var MockedAssets = new List<NMSI.MMX.API.Models.IAsset>();

            for (int c = 0; c < 3; c++)
                MockedAssets.Add(new Asset(mockMe: true));

            this.Assets = MockedAssets;
        }

        public static IEnumerable<Type> KnownTypes()
        {
            return new[] { typeof(mmxConnection), typeof(NMSI.MMX.API.Models.Object) };
        }


        #region Connections

        ///// <summary>
        ///// Gets or sets the agents.
        ///// </summary>
        ///// <value>
        ///// The agents.
        ///// </value>
        //[DataMember(IsRequired = false)]
        //[mmxLinkedAttribute(Predicate = "mmx:Agent")]
        //public IEnumerable<mmxConnection> Agents { get; set; }

        ///// <summary>
        ///// Gets or sets the exhibitions.
        ///// </summary>
        ///// <value>
        ///// The exhibitions.
        ///// </value>
        //[DataMember(IsRequired = false)]
        //[mmxLinkedAttribute(Predicate = "mmx:Exhibition")]
        //public IEnumerable<mmxConnection> Exhibitions { get; set; }

        ///// <summary>
        ///// Gets or sets the places.
        ///// </summary>
        ///// <value>
        ///// The places.
        ///// </value>
        //[DataMember(IsRequired = false)]
        //[mmxLinkedAttribute(Predicate = "mmx:Place")]
        //public IEnumerable<mmxConnection> Places { get; set; }

        ///// <summary>
        ///// Gets or sets the concepts.
        ///// </summary>
        ///// <value>
        ///// The concepts.
        ///// </value>
        //[DataMember(IsRequired = false)]
        //[mmxLinkedAttribute(Predicate = "mmx:Concept")]
        //public IEnumerable<mmxConnection> Concepts { get; set; }

        /// <summary>
        /// Gets or sets the assets.
        /// </summary>
        /// <value>
        /// The assets.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfLinkedEntityAttribute(Predicate = "mmx:Asset", Relator = "relatedObject", IType = "Asset")]
        public IEnumerable<IAsset> Assets { get; set; }

        #endregion

        #region Single Entity Properties

        [DataMember]
        [RdfSubjectAttribute(id = "Object")]
        [RdfNameAttribute(Key = "Object")]
        public string Uri { get; set; }

        [DataMember]
        [RdfNameAttribute(Key = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the accession number.
        /// </summary>
        /// <value>
        /// The accession number.
        /// </value>
        [DataMember(IsRequired=false)]
        [RdfPredicateAttribute(Predicate = "mmx:accessionNumber")]
        [RdfNameAttribute(Key = "accessionNumber")]
        public string AccessionNumber { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DataMember(IsRequired=false)]
        [RdfPredicateAttribute(Predicate = "rdfs:label")]
        [RdfNameAttribute(Key = "label")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the descriptive title.
        /// </summary>
        /// <value>
        /// The descriptive title.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:descriptiveTitle")]
        [RdfNameAttribute(Key = "descriptiveTitle")]
        public string DescriptiveTitle { get; set; }

        /// <summary>
        /// Gets or sets the materials.
        /// </summary>
        /// <value>
        /// The materials.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:materials")]
        [RdfNameAttribute(Key = "materials")]
        public string Materials { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:description")]
        [RdfNameAttribute(Key = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the extended description.
        /// </summary>
        /// <value>
        /// The extended description.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:extendedDescription")]
        [RdfNameAttribute(Key = "extendedDescription")]
        public string ExtendedDescription { get; set; }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>
        /// The note.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:note")]
        [RdfNameAttribute(Key = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the credit line.
        /// </summary>
        /// <value>
        /// The credit line.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:creditLine")]
        [RdfNameAttribute(Key = "creditLine")]
        public string CreditLine { get; set; }

        /// <summary>
        /// Gets or sets the location text.
        /// </summary>
        /// <value>
        /// The location text.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:locationText")]
        [RdfNameAttribute(Key = "locationText")]
        public string LocationText { get; set; }

        /// <summary>
        /// Gets or sets the name of the collection.
        /// </summary>
        /// <value>
        /// The name of the collection.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:collectionName")]
        [RdfNameAttribute(Key = "collectionName")]
        public string CollectionName { get; set; }

        /// <summary>
        /// Gets or sets the date text.
        /// </summary>
        /// <value>
        /// The date text.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:dateText")]
        [RdfNameAttribute(Key = "dateText")]
        public string DateText { get; set; }

        /// <summary>
        /// Gets or sets the ealiest date.
        /// </summary>
        /// <value>
        /// The ealiest date.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:ealiestDate")]
        [RdfNameAttribute(Key = "ealiestDate")]
        public string EaliestDate { get; set; }

        /// <summary>
        /// Gets or sets the latest date.
        /// </summary>
        /// <value>
        /// The latest date.
        /// </value>
        [DataMember(IsRequired = false)]
        [RdfPredicateAttribute(Predicate = "mmx:latestDate")]
        [RdfNameAttribute(Key = "latestDate")]
        public string LatestDate { get; set; }

        #endregion
    }
}
