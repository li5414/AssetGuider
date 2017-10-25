/*************************************************************************
 *  Copyright (C), 2017-2018, Mogoson Tech. Co., Ltd.
 *------------------------------------------------------------------------
 *  File         :  AssetGuiderSettings.cs
 *  Description  :  Config of Assets extension.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  8/30/2017
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace Developer.AssetGuider
{
    public class AssetGuiderSettings : ScriptableObject
    {
        #region Property and Field
        public string extensions = ".txt$|.shader$";
        #endregion
    }
}