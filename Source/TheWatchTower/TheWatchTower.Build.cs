// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TheWatchTower : ModuleRules
{
	public TheWatchTower(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TheWatchTower",
			"TheWatchTower/Variant_Horror",
			"TheWatchTower/Variant_Horror/UI",
			"TheWatchTower/Variant_Shooter",
			"TheWatchTower/Variant_Shooter/AI",
			"TheWatchTower/Variant_Shooter/UI",
			"TheWatchTower/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
