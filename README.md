# AssetGuider
- [中文手册](./README_ZH.md)

## Summary
- Unity Asset guider.

## Demand
- Config a guider to open Unity Asset use the OS default application.

## Environment
- Unity 5.0 or above.
- .Net Framework 3.5 or above.

## Prerequisite
- Unity provide the API(OnOpenAsset callback attribute) to capture the event of open Asset.

## Scheme
- Use a config file to record the extensions of Assets those we want to open them use our designated applications.
- Write extend editor code, capture the event of open Asset in Unity by OnOpenAsset callback attribute and get the
  extension of current Asset.
- Check the extension, if it was record in the config file, Use the OS default application to open it. if not, we
  do not handle it but Unity do.
- Set the default application of Asset by type(extension) in OS. example set "Sublime Text" as the default editor
  of Shader Asset.

## Preview
- Asset Guider

![Asset Guider Settings](./Attachments/README_Image/AssetGuider.gif)

## Contact
- If you have any questions, feel free to contact me at mogoson@outlook.com.