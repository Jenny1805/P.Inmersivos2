using UnrealBuildTool;

public class Blockout1ServerTarget : TargetRules
{
	public Blockout1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Blockout1");
	}
}
