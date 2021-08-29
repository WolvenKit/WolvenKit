using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsCHotSpotGameLogicFilterDefinition : ISerializable
	{
		private CHandle<gameIPrereq> _hotSpotPrereq;
		private CHandle<gameIPrereq> _activatorPrereq;
		private CHandle<gameinteractionsInteractionScriptedCondition> _scriptedConditionClass;

		[Ordinal(0)] 
		[RED("hotSpotPrereq")] 
		public CHandle<gameIPrereq> HotSpotPrereq
		{
			get => GetProperty(ref _hotSpotPrereq);
			set => SetProperty(ref _hotSpotPrereq, value);
		}

		[Ordinal(1)] 
		[RED("activatorPrereq")] 
		public CHandle<gameIPrereq> ActivatorPrereq
		{
			get => GetProperty(ref _activatorPrereq);
			set => SetProperty(ref _activatorPrereq, value);
		}

		[Ordinal(2)] 
		[RED("scriptedConditionClass")] 
		public CHandle<gameinteractionsInteractionScriptedCondition> ScriptedConditionClass
		{
			get => GetProperty(ref _scriptedConditionClass);
			set => SetProperty(ref _scriptedConditionClass, value);
		}
	}
}
