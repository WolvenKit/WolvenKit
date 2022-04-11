using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIJoinTargetsSquadCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public AIJoinTargetsSquadCommandParams()
		{
			TargetPuppetRef = new() { Names = new() };
		}
	}
}
