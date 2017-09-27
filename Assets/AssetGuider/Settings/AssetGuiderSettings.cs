/*************************************************************************
 *  Copyright (C), 2017-2018, Mogoson Tech. Co., Ltd.
 *  FileName: AssetGuiderSettings.cs
 *  Author: Mogoson   Version: 0.1.0   Date: 8/30/2017
 *  Version Description:
 *    Internal develop version,mainly to achieve its function.
 *  File Description:
 *    Ignore.
 *  Class List:
 *    <ID>           <name>             <description>
 *     1.      AssetGuiderSettings         Ignore.
 *  Function List:
 *    <class ID>     <name>             <description>
 *     1.
 *  History:
 *    <ID>    <author>      <time>      <version>      <description>
 *     1.     Mogoson     8/30/2017       0.1.0       Create this file.
 *************************************************************************/

namespace Developer.AssetGuider
{
    using UnityEngine;

    public class AssetGuiderSettings : ScriptableObject
    {
        #region Property and Field
        public string extensions = ".txt|.shader";
        #endregion
    }
}