using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutputValidationDataStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("agentID")] 
		public gamePersistentID AgentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(2)] 
		[RED("reprimenderID")] 
		public entEntityID ReprimenderID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(3)] 
		[RED("eventReportedFromArea")] 
		public gamePersistentID EventReportedFromArea
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<ESecurityNotificationType> EventType
		{
			get => GetPropertyValue<CEnum<ESecurityNotificationType>>();
			set => SetPropertyValue<CEnum<ESecurityNotificationType>>(value);
		}

		[Ordinal(5)] 
		[RED("breachedAreas")] 
		public CArray<gamePersistentID> BreachedAreas
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		public OutputValidationDataStruct()
		{
			TargetID = new entEntityID();
			AgentID = new gamePersistentID();
			ReprimenderID = new entEntityID();
			EventReportedFromArea = new gamePersistentID();
			BreachedAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
