using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;


namespace SharedConfigurableUpgradesChance
{
    [BepInPlugin("AutoChrome.SharedConfigurableUpgradesChance", "SharedConfigurableUpgradesChance", "1.0")]
    [BepInDependency(REPOLib.MyPluginInfo.PLUGIN_GUID, BepInDependency.DependencyFlags.HardDependency)]
    public class SharedConfigurableUpgradesChance : BaseUnityPlugin
    {
        internal static SharedConfigurableUpgradesChance Instance { get; private set; } = null!;
        internal new static ManualLogSource Logger => Instance._logger;
        private ManualLogSource _logger => base.Logger;
        internal Harmony? Harmony { get; set; }

        private void Awake()
        {
            Instance = this;

            Harmony val = new Harmony("SharedConfigurableUpgradesChance");

            // Prevent the plugin from being deleted
            this.gameObject.transform.parent = null;
            this.gameObject.hideFlags = HideFlags.HideAndDontSave;

            Upgrader.InitializeConfig(base.Config);

            Logger.LogInfo($"{Info.Metadata.GUID} v{Info.Metadata.Version} has loaded!");

            List<MethodInfo> upgradeName = new List<MethodInfo>();
            List<MethodInfo> upgradeMethod = new List<MethodInfo>();
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradeMapPlayerCount), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradeMapPlayerCount_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerEnergy), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerEnergy_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerExtraJump), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerExtraJump_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerGrabRange), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerGrabRange_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerGrabStrength), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerGrabStrength_Patch.Upgrade_Patch())));
            upgradeName .Add(AccessTools.Method(typeof(ItemUpgradePlayerGrabThrow), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerGrabThrow_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerHealth), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerHealth_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerSprintSpeed), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerSprintSpeed_Patch.Upgrade_Patch())));
            upgradeName.Add(AccessTools.Method(typeof(ItemUpgradePlayerTumbleLaunch), "Upgrade", (Type[])null, (Type[])null));
            upgradeMethod.Add(SymbolExtensions.GetMethodInfo((Expression<Action>)(() => Upgrader.ItemUpgradePlayerTumbleLaunch_Patch.Upgrade_Patch())));
            for (int i = 0; i < upgradeName.Count; i++)
            {
                val.Patch((MethodBase)upgradeName[i], new HarmonyMethod(upgradeMethod[i]), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
            }
        }
    }
}