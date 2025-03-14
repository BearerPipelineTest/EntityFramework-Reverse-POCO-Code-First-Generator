// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // table mapping with space
    public class TableMappingWithSpace
    {
        public int Id { get; set; } // id (Primary key)
        public int IdValue { get; set; } // id value (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TableWithSpace pointed by [table mapping with space].([Id]) (space1FK)
        /// </summary>
        public virtual TableWithSpace TableWithSpace { get; set; } // space1FK

        /// <summary>
        /// Parent TableWithSpaceAndInColumn pointed by [table mapping with space].([IdValue]) (space2FK)
        /// </summary>
        public virtual TableWithSpaceAndInColumn TableWithSpaceAndInColumn { get; set; } // space2FK
    }

}
// </auto-generated>
