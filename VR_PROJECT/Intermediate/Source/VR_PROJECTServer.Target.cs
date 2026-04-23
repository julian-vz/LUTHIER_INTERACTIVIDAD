using UnrealBuildTool;

public class VR_PROJECTServerTarget : TargetRules
{
	public VR_PROJECTServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VR_PROJECT");
	}
}
