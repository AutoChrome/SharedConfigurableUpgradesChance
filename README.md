Overview
The SharedConfigurableUpgradesChance plugin introduces a configurable system for upgrading player attributes based on the number of players in the game. This plugin allows game hosts to set the probability of various upgrades being applied to players, ensuring a balanced and customizable gameplay experience.
Features
- Configurable Upgrade Chances: game hosts can configure the probability of each upgrade being applied based on the number of players.
- Logging: Detailed logging for each upgrade attempt, including the generated chance and whether the upgrade was applied.
Configuration
The plugin uses a configuration file to set the probabilities for each upgrade. The key configuration entries are:
- playerValue: The base value used to calculate the upgrade chance per player.
- maxCap: The maximum cap for the upgrade chance, ensuring it does not exceed a certain percentage.

How It Works
1.	Initialization: The plugin initializes the configuration using the InitializeConfig method.
2.	Upgrade Calculation: For each player, the plugin calculates the upgrade chance based on the number of players and the configured playerValue and maxCap.
3.	Random Chance: A random value is generated, and if it is less than or equal to the calculated chance, the upgrade is applied to the player.
4.	Logging: Each upgrade attempt is logged, providing insights into the upgrade process.

Installation
1.	Download the plugin and place it in the BepInEx/plugins directory.
2.	Configure the playerValue and maxCap in the configuration file.
3.	Start the game, and the plugin will automatically apply the configured upgrade chances.