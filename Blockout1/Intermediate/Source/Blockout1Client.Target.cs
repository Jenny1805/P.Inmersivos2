using UnrealBuildTool;

public class Blockout1ClientTarget : TargetRules
{
	public Blockout1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Blockout1");
	}
}
