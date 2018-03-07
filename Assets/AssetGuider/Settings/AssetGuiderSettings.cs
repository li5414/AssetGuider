﻿/*************************************************************************
 *  Copyright © 2017-2018 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AssetGuiderSettings.cs
 *  Description  :  Config of Assets extension.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  3/7/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace Developer.AssetGuider
{
    public class AssetGuiderSettings : ScriptableObject
    {
        #region Field and Property
        public string extensions = ".txt$|.shader$";
        #endregion
    }
}