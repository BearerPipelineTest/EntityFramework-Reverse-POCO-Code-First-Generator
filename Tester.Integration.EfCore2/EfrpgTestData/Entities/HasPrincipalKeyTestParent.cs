// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    // HasPrincipalKeyTestParent
    public class HasPrincipalKeyTestParent
    {
        public int Id { get; set; } // Id (Primary key)
        public int Aa { get; set; } // AA
        public int Bb { get; set; } // BB
        public int? Cc { get; set; } // CC
        public int? Dd { get; set; } // DD

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) HasPrincipalKeyTestParent pointed by [HasPrincipalKeyTestChild].([A], [B]) (FK_HasPrincipalKey_AB)
        /// </summary>
        public virtual HasPrincipalKeyTestChild HasPrincipalKeyTestChild { get; set; } // HasPrincipalKeyTestChild.FK_HasPrincipalKey_AB

        /// <summary>
        /// Child HasPrincipalKeyTestChilds where [HasPrincipalKeyTestChild].[C] point to this entity (FK_HasPrincipalKey_AC)
        /// </summary>
        public virtual ICollection<HasPrincipalKeyTestChild> HasPrincipalKeyTestChilds_C { get; set; } // HasPrincipalKeyTestChild.FK_HasPrincipalKey_AC

        /// <summary>
        /// Child HasPrincipalKeyTestChilds where [HasPrincipalKeyTestChild].[D] point to this entity (FK_HasPrincipalKey_CD)
        /// </summary>
        public virtual ICollection<HasPrincipalKeyTestChild> HasPrincipalKeyTestChilds_D { get; set; } // HasPrincipalKeyTestChild.FK_HasPrincipalKey_CD

        public HasPrincipalKeyTestParent()
        {
            HasPrincipalKeyTestChilds_C = new List<HasPrincipalKeyTestChild>();
            HasPrincipalKeyTestChilds_D = new List<HasPrincipalKeyTestChild>();
        }
    }

}
// </auto-generated>
