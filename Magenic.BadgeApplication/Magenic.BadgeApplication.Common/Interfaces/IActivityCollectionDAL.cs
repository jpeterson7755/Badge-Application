﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Magenic.BadgeApplication.Common.DTO;

namespace Magenic.BadgeApplication.Common.Interfaces
{
    /// <summary>
    /// Data Access Layer interface to load for classes implementing <see cref="IActivityCollection"/>.
    /// </summary>
    public interface IActivityCollectionDAL
    {
        /// <summary>
        /// Returns an <see cref="System.Collections.IEnumerable"/> for all activities in the system.
        /// </summary>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        Task<IEnumerable<ActivityItemDTO>> GetAllActvitiesAsync();
    }
}
