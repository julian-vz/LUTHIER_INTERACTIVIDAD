using UnrealBuildTool;

public class VR_PROJECTEditorTarget : TargetRules
{
	public VR_PROJECTEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VR_PROJECT");
	}
}
