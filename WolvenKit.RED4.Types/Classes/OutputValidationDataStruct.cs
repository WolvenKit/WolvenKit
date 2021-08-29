using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutputValidationDataStruct : RedBaseClass
	{
		private entEntityID _targetID;
		private gamePersistentID _agentID;
		private entEntityID _reprimenderID;
		private gamePersistentID _eventReportedFromArea;
		private CEnum<ESecurityNotificationType> _eventType;
		private CArray<gamePersistentID> _breachedAreas;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(1)] 
		[RED("agentID")] 
		public gamePersistentID AgentID
		{
			get => GetProperty(ref _agentID);
			set => SetProperty(ref _agentID, value);
		}

		[Ordinal(2)] 
		[RED("reprimenderID")] 
		public entEntityID ReprimenderID
		{
			get => GetProperty(ref _reprimenderID);
			set => SetProperty(ref _reprimenderID, value);
		}

		[Ordinal(3)] 
		[RED("eventReportedFromArea")] 
		public gamePersistentID EventReportedFromArea
		{
			get => GetProperty(ref _eventReportedFromArea);
			set => SetProperty(ref _eventReportedFromArea, value);
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<ESecurityNotificationType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		[Ordinal(5)] 
		[RED("breachedAreas")] 
		public CArray<gamePersistentID> BreachedAreas
		{
			get => GetProperty(ref _breachedAreas);
			set => SetProperty(ref _breachedAreas, value);
		}
	}
}
