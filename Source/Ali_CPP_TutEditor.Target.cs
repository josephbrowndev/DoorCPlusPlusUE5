// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Ali_CPP_TutEditorTarget : TargetRules
{
    public Ali_CPP_TutEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
        ExtraModuleNames.Add("Ali_CPP_Tut");
    }
}
