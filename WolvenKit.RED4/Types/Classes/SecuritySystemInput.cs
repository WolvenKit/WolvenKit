using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemInput : SecurityAreaEvent
	{
		[Ordinal(40)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(41)] 
		[RED("notifier")] 
		public CHandle<SharedGameplayPS> Notifier
		{
			get => GetPropertyValue<CHandle<SharedGameplayPS>>();
			set => SetPropertyValue<CHandle<SharedGameplayPS>>(value);
		}

		[Ordinal(42)] 
		[RED("type")] 
		public CEnum<ESecurityNotificationType> Type
		{
			get => GetPropertyValue<CEnum<ESecurityNotificationType>>();
			set => SetPropertyValue<CEnum<ESecurityNotificationType>>(value);
		}

		[Ordinal(43)] 
		[RED("objectOfInterest")] 
		public CWeakHandle<gameObject> ObjectOfInterest
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(44)] 
		[RED("canPerformReprimand")] 
		public CBool CanPerformReprimand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("shouldLeadReprimend")] 
		public CBool ShouldLeadReprimend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(47)] 
		[RED("customRecipientsList")] 
		public CArray<entEntityID> CustomRecipientsList
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(48)] 
		[RED("isSharingRestricted")] 
		public CBool IsSharingRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("debugReporterCharRecord")] 
		public CHandle<gamedataCharacter_Record> DebugReporterCharRecord
		{
			get => GetPropertyValue<CHandle<gamedataCharacter_Record>>();
			set => SetPropertyValue<CHandle<gamedataCharacter_Record>>(value);
		}

		[Ordinal(50)] 
		[RED("stimTypeTriggeredAlarm")] 
		public CEnum<gamedataStimType> StimTypeTriggeredAlarm
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		public SecuritySystemInput()
		{
			LastKnownPosition = new Vector4();
			Id = -1;
			CustomRecipientsList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
