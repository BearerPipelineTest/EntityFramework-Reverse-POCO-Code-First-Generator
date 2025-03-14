// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5EfrpgTest
{
    // CMS_File
    public class CmsFile
    {
        public int FileId { get; set; } // FileId (Primary key)
        public string FileName { get; set; } // FileName (length: 100)
        public string FileDescription { get; set; } // FileDescription (length: 500)
        public string FileIdentifier { get; set; } // FileIdentifier (length: 100)
        public DateTime? ValidStartDate { get; set; } // ValidStartDate
        public DateTime? ValidEndDate { get; set; } // ValidEndDate
        public bool IsActive { get; set; } // IsActive

        // Reverse navigation

        /// <summary>
        /// Child CmsTags (Many-to-Many) mapped by table [CMS_FileTag]
        /// </summary>
        public virtual ICollection<CmsTag> CmsTags { get; set; } // Many to many mapping

        public CmsFile()
        {
            CmsTags = new List<CmsTag>();
        }
    }

}
// </auto-generated>
