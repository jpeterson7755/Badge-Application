﻿using Csla;
using Magenic.BadgeApplication.Common.Enums;
using Magenic.BadgeApplication.Common.Interfaces;
using System;

namespace Magenic.BadgeApplication.BusinessLogic.Badge
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class BadgeItem : BusinessBase<BadgeItem>, IBadgeItem
    {
        #region Properties

        /// <summary>
        /// The identifier property
        /// </summary>
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(b => b.Id);
        /// <summary>
        /// The id of the badge.
        /// </summary>
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { SetProperty(IdProperty, value); }
        }

        /// <summary>
        /// The name property
        /// </summary>
        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(b => b.Name);
        /// <summary>
        /// The name of a badge.
        /// </summary>
        public string Name
        {
            get { return GetProperty(NameProperty); }
            private set { SetProperty(NameProperty, value); }
        }

        /// <summary>
        /// The type property
        /// </summary>
        public static readonly PropertyInfo<BadgeType> TypeProperty = RegisterProperty<BadgeType>(b => b.Type);
        /// <summary>
        /// The type of the badge, corporate or community.
        /// </summary>
        public BadgeType Type
        {
            get { return GetProperty(TypeProperty); }
            private set { SetProperty(TypeProperty, value); }
        }

        /// <summary>
        /// The image path property
        /// </summary>
        public static readonly PropertyInfo<string> ImagePathProperty = RegisterProperty<string>(b => b.ImagePath);
        /// <summary>
        /// The path to where the badge's image resides.
        /// </summary>
        public string ImagePath
        {
            get { return GetProperty(ImagePathProperty); }
            private set { SetProperty(ImagePathProperty, value); }
        }

        #endregion Properties

        #region Methods

        internal void Load(IBadgeItemDTO item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Type = item.Type;
            this.ImagePath = item.ImagePath;
        }

        #endregion Methods
    }
}