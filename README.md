# Customize Thrall Speed

### Env Variables for .csproj setup.

The .csproj file has two environment variables that set where the plugin's source code is and where your V Rising install are. These are used for the unhollowed directory and to automatically copy the compiled .dll into your vrising install.

These environment variables are VRising_Dev_Folder and VRising_Location. Commands to set these on windows and Hero's locations for these folders as a example are shown below.

```
setx VRising_Dev_Folder "G:\Code\C#\BepInExVRising"
setx VRising_Location "C:\Program Files (x86)\Steam\steamapps\common\VRising\BepInEx"
```