using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDrillingState_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<questDrillingState> State
		{
			get => GetPropertyValue<CEnum<questDrillingState>>();
			set => SetPropertyValue<CEnum<questDrillingState>>(value);
		}

		public questDrillingState_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
