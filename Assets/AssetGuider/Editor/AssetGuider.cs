/*************************************************************************
 *  Copyright (C), 2017-2018, Mogoson Tech. Co., Ltd.
 *------------------------------------------------------------------------
 *  File         :  AssetGuider.cs
 *  Description  :  Capture the event of open Asset in Unity and call OS
 *                  open the Asset use the default application.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  8/30/2017
 *  Description  :  Initial development version.
 *************************************************************************/

using System.IO;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace Developer.AssetGuider
{
    public static class AssetGuider
    {
        #region Property and Field
        private const string settingsPath = "Assets/AssetGuider/Settings/AssetGuiderSettings.asset";
        #endregion

        #region Private Method
        [MenuItem("Tool/Asset Guider Settings &G")]
        private static void FocusSettings()
        {
            var settings = AssetDatabase.LoadAssetAtPath(settingsPath, typeof(AssetGuiderSettings)) as AssetGuiderSettings;
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
            var settings = AssetDatabase.LoadAssetAtPath(settingsPath, typeof(AssetGuiderSettings)) as AssetGuiderSettings;
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