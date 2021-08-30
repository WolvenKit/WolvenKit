using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questBehind_ConditionType : questISensesConditionType
	{
		private gameEntityReference _targetRef;
		private CEnum<questBehindInteractionEventType> _eventType;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questBehindInteractionEventType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		public questBehind_ConditionType()
		{
			_eventType = new() { Value = Enums.questBehindInteractionEventType.StartedBeingBehind };
		}
	}
}
