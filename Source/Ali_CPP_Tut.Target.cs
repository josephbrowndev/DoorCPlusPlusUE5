// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Ali_CPP_TutTarget : TargetRules
{
    public Ali_CPP_TutTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
        ExtraModuleNames.Add("Ali_CPP_Tut");
    }
}
