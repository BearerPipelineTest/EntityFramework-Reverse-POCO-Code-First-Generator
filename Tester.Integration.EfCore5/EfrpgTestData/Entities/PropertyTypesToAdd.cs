// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5EfrpgTest
{
    // PropertyTypesToAdd
    public class PropertyTypesToAdd
    {
        public int Id { get; set; } // id (Primary key)
        public DateTime? DtDefault { get; set; } // dt_default
        public DateTime? Dt7 { get; set; } // dt7
        public string DefaultCheck { get; set; } // defaultCheck (length: 10)

        // Reverse navigation

        /// <summary>
        /// Child Beta_Harish3485 where [Harish3485].[another_id] point to this entity (FK_Harish)
        /// </summary>
        public virtual ICollection<Beta_Harish3485> Beta_Harish3485 { get; set; } // Harish3485.FK_Harish

        public PropertyTypesToAdd()
        {
            Beta_Harish3485 = new List<Beta_Harish3485>();
        }
    }

}
// </auto-generated>
