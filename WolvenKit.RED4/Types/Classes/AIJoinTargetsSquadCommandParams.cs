using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
