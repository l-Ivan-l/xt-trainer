using UnrealBuildTool;

public class XT_TrainerTarget : TargetRules
{
	public XT_TrainerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("XT_Trainer");
	}
}
