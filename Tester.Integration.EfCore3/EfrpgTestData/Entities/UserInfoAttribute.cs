// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // UserInfoAttributes
    public class UserInfoAttribute
    {
        public int Id { get; set; } // Id (Primary key)
        public int PrimaryId { get; set; } // PrimaryId
        public int SecondaryId { get; set; } // SecondaryId

        // Foreign keys

        /// <summary>
        /// Parent UserInfo pointed by [UserInfoAttributes].([PrimaryId]) (FK_UserInfoAttributes_PrimaryUserInfo)
        /// </summary>
        public virtual UserInfo Primary { get; set; } // FK_UserInfoAttributes_PrimaryUserInfo

        /// <summary>
        /// Parent UserInfo pointed by [UserInfoAttributes].([SecondaryId]) (FK_UserInfoAttributes_SecondaryUserInfo)
        /// </summary>
        public virtual UserInfo Secondary { get; set; } // FK_UserInfoAttributes_SecondaryUserInfo
    }

}
// </auto-generated>
