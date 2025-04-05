using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using HarmonyLib;
using REPOLib;
using UnityEngine;

using Random = System.Random;

namespace SharedConfigurableUpgradesChance
{
    public class Upgrader
    {
        internal static ConfigHelper configHelper { get; private set; } = null!;

        public static void InitializeConfig(ConfigFile configFile)
        {
            configHelper = new ConfigHelper(configFile);
        }

        public class ItemUpgradeMapPlayerCount_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0;
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradeMapPlayerCount(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Map Player Count upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerEnergy_Patch : MonoBehaviour
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerEnergy(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Player Energy upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerExtraJump_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerExtraJump(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Extra Jump upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerGrabRange_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerGrabRange(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Grab Range upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerGrabStrength_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerGrabStrength(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Grab Strength upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerGrabThrow_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerThrowStrength(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Throw Strength upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerHealth_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerHealth(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Health upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerSprintSpeed_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerSprintSpeed(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Sprint Speed upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }

        public class ItemUpgradePlayerTumbleLaunch_Patch
        {
            public static bool Upgrade_Patch()
            {
                List<PlayerAvatar> list = SemiFunc.PlayerGetAll();
                foreach (PlayerAvatar item in list)
                {
                    double playerValue = configHelper.playerValue.Value / 100.0; // Convert to decimal
                    double maxCap = configHelper.maxCap.Value / 100.0; // Convert to decimal
                    int playerCount = list.Count;
                    double chance = Math.Min(maxCap, (playerCount * playerValue)); // Scale chance with player count, max 50%
                    Random random = new Random();
                    double randomValue = random.NextDouble(); // Generate a random number between 0 and 1
                    SharedConfigurableUpgradesChance.Logger.LogInfo($"Chance generated for: {SemiFunc.PlayerGetName(item)} : {randomValue}, Less than or equal to: {chance}, Max Cap: {maxCap}, Player Value: {playerValue}");
                    if (randomValue <= chance)
                    {
                        PunManager.instance.UpgradePlayerTumbleLaunch(SemiFunc.PlayerGetSteamID(item));
                        SharedConfigurableUpgradesChance.Logger.LogInfo($"Tumble Launch upgrade given to: {SemiFunc.PlayerGetName(item)}");
                    }
                }
                return true;
            }
        }
    }
}
