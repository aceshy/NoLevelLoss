# NoLevelLoss

Prevents you from losing levels when dying in Valheim.

## Installing

1. install [BepInEx](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim)
2. download `kieva.plugins.Valheim.NoLevelLoss.dll` from [the releases](https://github.com/idijt/NoLevelLoss/releases/latest)
3. put the file you downloaded in `BepInEx/plugins/` located in valheim's root directory

## Setting up

You need [.NET SDK 6](https://dotnet.microsoft.com/) or newer

1. populate `lib` folder with `assembly_valheim.dll`
   - this can be found in the game's `Valheim_Data/Managed`
2. run `dotnet restore`

## Building

1. run `dotnet build`
2. The output can be found in `bin/Debug/net46`
