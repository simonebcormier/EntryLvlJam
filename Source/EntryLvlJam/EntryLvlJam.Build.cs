// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EntryLvlJam : ModuleRules
{
	public EntryLvlJam(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
