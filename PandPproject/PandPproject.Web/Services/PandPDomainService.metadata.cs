
namespace PandPproject.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies MembersMetadata as the class
    // that carries additional metadata for the Members class.
    [MetadataTypeAttribute(typeof(Members.MembersMetadata))]
    public partial class Members
    {

        // This class allows you to attach custom attributes to properties
        // of the Members class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class MembersMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private MembersMetadata()
            {
            }

            public string Email { get; set; }

            public int ID { get; set; }

            public string Name { get; set; }

            public string Password { get; set; }

            public string Rank { get; set; }

            public EntityCollection<Traffic> Traffic { get; set; }

            public string UserName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies sysdiagramsMetadata as the class
    // that carries additional metadata for the sysdiagrams class.
    [MetadataTypeAttribute(typeof(sysdiagrams.sysdiagramsMetadata))]
    public partial class sysdiagrams
    {

        // This class allows you to attach custom attributes to properties
        // of the sysdiagrams class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class sysdiagramsMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private sysdiagramsMetadata()
            {
            }

            public byte[] definition { get; set; }

            public int diagram_id { get; set; }

            public string name { get; set; }

            public int principal_id { get; set; }

            public Nullable<int> version { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies TrafficMetadata as the class
    // that carries additional metadata for the Traffic class.
    [MetadataTypeAttribute(typeof(Traffic.TrafficMetadata))]
    public partial class Traffic
    {

        // This class allows you to attach custom attributes to properties
        // of the Traffic class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TrafficMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TrafficMetadata()
            {
            }

            public Nullable<DateTime> Arrival { get; set; }

            public Nullable<DateTime> Departure { get; set; }

            public Nullable<int> GPSPickUp { get; set; }

            public int ID { get; set; }

            public int MemberID { get; set; }

            public Members Members { get; set; }
        }
    }
}
