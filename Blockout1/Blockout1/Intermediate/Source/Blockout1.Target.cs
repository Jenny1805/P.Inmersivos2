using UnrealBuildTool;

public class Blockout1Target : TargetRules
{
	public Blockout1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Blockout1");
	}
}
