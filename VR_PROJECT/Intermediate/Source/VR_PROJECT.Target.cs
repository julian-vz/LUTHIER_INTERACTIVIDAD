using UnrealBuildTool;

public class VR_PROJECTTarget : TargetRules
{
	public VR_PROJECTTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_PROJECT");
	}
}
