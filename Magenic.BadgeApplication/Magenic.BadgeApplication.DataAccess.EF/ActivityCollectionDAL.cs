﻿using Magenic.BadgeApplication.Common.DTO;
using Magenic.BadgeApplication.Common.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Magenic.BadgeApplication.DataAccess.EF
{
    public class ActivityCollectionDAL : IActivityCollectionDAL
    {
        public async Task<IEnumerable<ActivityItemDTO>> GetAllActvitiesAsync()
        {
            using (var ctx = new Entities())
            {
                ctx.Database.Connection.Open();
                var activityList = await (from t in ctx.Activities
                                          select new ActivityItemDTO
                                          {
                                              Id = t.ActivityId,
                                              Name = t.ActivityName,
                                              BadgeIds = t.BadgeActivities.Select(ba => ba.BadgeId),
                                          }).ToArrayAsync();

                return activityList;
            }
        }
    }
}
