using System;

namespace NMSI.MMX.API.Models
{
    public interface IObject
    {
        string AccessionNumber { get; set; }
        string CollectionName { get; set; }
        string CreditLine { get; set; }
        string DateText { get; set; }
        string Description { get; set; }
        string DescriptiveTitle { get; set; }
        string EaliestDate { get; set; }
        string ExtendedDescription { get; set; }
        string Id { get; }
        string LatestDate { get; set; }
        string LocationText { get; set; }
        string Materials { get; set; }
        string Note { get; set; }
        string Title { get; set; }
        string Uri { get; set; }

        System.Collections.Generic.IEnumerable<IAsset> Assets { get; set; }

        //System.Collections.Generic.IEnumerable<mmxConnection> Agents { get; set; }
        //System.Collections.Generic.IEnumerable<mmxConnection> Concepts { get; set; }
        //System.Collections.Generic.IEnumerable<mmxConnection> Exhibitions { get; set; }
        //System.Collections.Generic.IEnumerable<mmxConnection> Places { get; set; }
    }

    public interface IObjectCompact
    {
        string Id { get; set; }
        string Uri { get; set; }

        string AccessionNumber { get; set; }
        string Title { get; set; }
        
        System.Collections.Generic.IEnumerable<IAsset> Assets { get; set; }
    }
}
