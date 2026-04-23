using UnrealBuildTool;

public class VR_PROJECTClientTarget : TargetRules
{
	public VR_PROJECTClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("VR_PROJECT");
	}
}
