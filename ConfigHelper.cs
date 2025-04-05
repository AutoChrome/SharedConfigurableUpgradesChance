namespace SharedConfigurableUpgradesChance
{
    using System;
    using BepInEx.Configuration;

    public class ConfigHelper
    {
	    public readonly ConfigEntry<int> playerValue;
	    public readonly ConfigEntry<int> maxCap;

	    public ConfigHelper(ConfigFile cfg)
	    {

            playerValue = cfg.Bind(
                "General",                          // Config section
                "Player Percent Value",                     // Key of this config
                5,                    // Default value
                new ConfigDescription(
                    "The percentage increase in chance for each additional player. For example, if set to 5, each player increases the chance by 5%.",
                    new AcceptableValueRange<int>(1, 100) // Acceptable value range
                )
            );

            maxCap = cfg.Bind(
                "General",                          // Config section
                "Max cap",             // Key of this config
                50,                                  // Default value
                new ConfigDescription(
                    "The maximum percentage cap for the chance. This value ensures that the chance does not exceed this percentage, regardless of the number of players.",
                    new AcceptableValueRange<int>(1, 100) // Acceptable value range
                )
            );
        }
    }
}

