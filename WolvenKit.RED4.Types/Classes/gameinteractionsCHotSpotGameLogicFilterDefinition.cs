using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCHotSpotGameLogicFilterDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("hotSpotPrereq")] 
		public CHandle<gameIPrereq> HotSpotPrereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}

		[Ordinal(1)] 
		[RED("activatorPrereq")] 
		public CHandle<gameIPrereq> ActivatorPrereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}

		[Ordinal(2)] 
		[RED("scriptedConditionClass")] 
		public CHandle<gameinteractionsInteractionScriptedCondition> ScriptedConditionClass
		{
			get => GetPropertyValue<CHandle<gameinteractionsInteractionScriptedCondition>>();
			set => SetPropertyValue<CHandle<gameinteractionsInteractionScriptedCondition>>(value);
		}

		public gameinteractionsCHotSpotGameLogicFilterDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
