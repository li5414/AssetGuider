/*************************************************************************
 *  Copyright (C), 2017-2018, Mogoson Tech. Co., Ltd.
 *  FileName: AssetGuider.cs
 *  Author: Mogoson   Version: 0.1.0   Date: 8/30/2017
 *  Version Description:
 *    Internal develop version,mainly to achieve its function.
 *  File Description:
 *    Ignore.
 *  Class List:
 *    <ID>           <name>             <description>
 *     1.          AssetGuider             Ignore.
 *  Function List:
 *    <class ID>     <name>             <description>
 *     1.
 *  History:
 *    <ID>    <author>      <time>      <version>      <description>
 *     1.     Mogoson     8/30/2017       0.1.0       Create this file.
 *************************************************************************/

namespace Developer.AssetGuider
{
    using System.IO;
    using System.Text.RegularExpressions;
    using UnityEditor;
    using UnityEditor.Callbacks;
    using UnityEngine;

    public static class AssetGuider
    {
        #region Property and Field
        private const string settingsPath = "Assets/AssetGuider/Settings/AssetGuiderSettings.asset";
        #endregion

        #region Private Method
        [MenuItem("Tool/Asset Guider Settings &G")]
        private static void FocusSettings()
        {
            var settings = AssetDatabase.LoadAssetAtPath<AssetGuiderSettings>(settingsPath);
            if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<AssetGuiderSettings>();
                AssetDatabase.CreateAsset(settings, settingsPath);
            }
            Selection.activeObject = settings;
        }

        [OnOpenAsset]
        private static bool OnOpenAsset(int instanceID, int line)
        {
            var settings = AssetDatabase.LoadAssetAtPath<AssetGuiderSettings>(settingsPath);
            if (settings == null)
                return false;
            var assetAbsolutePath = Application.dataPath + "/" + AssetDatabase.GetAssetPath(instanceID).Replace("Assets", string.Empty);
            if (Regex.IsMatch(Path.GetExtension(assetAbsolutePath), settings.extensions))
            {
                Application.OpenURL(assetAbsolutePath);
                return true;
            }
            else
                return false;
        }
        #endregion
    }
}