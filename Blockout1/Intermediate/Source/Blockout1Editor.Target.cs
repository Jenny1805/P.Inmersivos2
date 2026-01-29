using UnrealBuildTool;

public class Blockout1EditorTarget : TargetRules
{
	public Blockout1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Blockout1");
	}
}
