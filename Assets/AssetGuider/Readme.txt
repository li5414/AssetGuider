==========================================================================
  Copyright © 2017-2018 Mogoson. All rights reserved.
  Name: AssetGuider
  Author: Mogoson   Version: 0.1.0   Date: 3/7/2018
==========================================================================
  [Summary]
    Unity Asset guider.
--------------------------------------------------------------------------
  [Demand]
    Config a guider to open Unity Asset use the OS default application.
--------------------------------------------------------------------------
  [Environment]
    Unity 5.0 or above.
    .Net Framework 3.0 or above.
--------------------------------------------------------------------------
  [Achieve]
    AssetGuiderSettings : Config of Assets extension.

    AssetGuider : Capture the event of open Asset in Unity and call OS
    open the Asset use the default application.
--------------------------------------------------------------------------
  [Usage]
    Find the menu item "Tool/Asset Guider Settings" in Unity editor menu
    bar and click it or press key combination Alt+G to create(if none)
    and focus the AssetGuiderSettings.

    Config the "Extensions" of AssetGuiderSettings in Unity Inspector.

    Set the default application of Asset by type(extension) in OS.
    example set "Sublime Text" as the default editor of Shader Asset.

    AssetGuider will be work when the Asset(it's extension config in the
    AssetGuiderSettings, example Shader) will be opened.
--------------------------------------------------------------------------
  [Resource]
    https://github.com/mogoson/AssetGuider.
--------------------------------------------------------------------------
  [Contact]
    If you have any questions, feel free to contact me at mogoson@outlook.com.
--------------------------------------------------------------------------