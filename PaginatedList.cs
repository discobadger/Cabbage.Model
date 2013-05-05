using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Cabbage.Common;

namespace NMSI.MMX.API.Models
{
    [KnownType("KnownTypes")]
    [DataContract(Namespace = "")]
    public class PaginatedList<T> : IPaginatedList<T>
    {
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        [DataMember]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        [DataMember]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>
        /// The offset.
        /// </value>
        [DataMember]
        public int Offset { get; set; }

        [DataMember]
        public List<T> Items { get; set; }


        public PaginatedList()
        {
        }

        public PaginatedList(bool mockMe)
        {
            if (mockMe)
            {
                MockMe();
            }
        }

        public static IEnumerable<Type> KnownTypes()
        {
            return new[] { typeof(NMSI.MMX.API.Models.Object), typeof(PaginatedList<T>) };
        }

        private void MockMe()
        {
            var listType = typeof(T);

            this.Limit = 10;
            this.Offset = 0;
            this.Total = 100;

            this.Items = new List<T>();
        }
    }
}