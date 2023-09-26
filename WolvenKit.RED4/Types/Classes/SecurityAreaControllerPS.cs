using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get => GetPropertyValue<CHandle<SecuritySystemControllerPS>>();
			set => SetPropertyValue<CHandle<SecuritySystemControllerPS>>(value);
		}

		[Ordinal(109)] 
		[RED("usersInPerimeter")] 
		public CArray<AreaEntry> UsersInPerimeter
		{
			get => GetPropertyValue<CArray<AreaEntry>>();
			set => SetPropertyValue<CArray<AreaEntry>>(value);
		}

		[Ordinal(110)] 
		[RED("isPlayerInside")] 
		public CBool IsPlayerInside
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("securityAccessLevel")] 
		public CEnum<ESecurityAccessLevel> SecurityAccessLevel
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		[Ordinal(112)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(113)] 
		[RED("eventsFilters")] 
		public EventsFilters EventsFilters
		{
			get => GetPropertyValue<EventsFilters>();
			set => SetPropertyValue<EventsFilters>(value);
		}

		[Ordinal(114)] 
		[RED("areaTransitions")] 
		public CArray<AreaTypeTransition> AreaTransitions
		{
			get => GetPropertyValue<CArray<AreaTypeTransition>>();
			set => SetPropertyValue<CArray<AreaTypeTransition>>(value);
		}

		[Ordinal(115)] 
		[RED("runtimeTransitions")] 
		public CArray<AreaTypeTransition> RuntimeTransitions
		{
			get => GetPropertyValue<CArray<AreaTypeTransition>>();
			set => SetPropertyValue<CArray<AreaTypeTransition>>(value);
		}

		[Ordinal(116)] 
		[RED("pendingDisableRequest")] 
		public CBool PendingDisableRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("lastOutput")] 
		public OutputPersistentData LastOutput
		{
			get => GetPropertyValue<OutputPersistentData>();
			set => SetPropertyValue<OutputPersistentData>(value);
		}

		[Ordinal(118)] 
		[RED("questPlayerHasTriggeredCombat")] 
		public CBool QuestPlayerHasTriggeredCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("hasThisAreaReceivedCombatNotification")] 
		public CBool HasThisAreaReceivedCombatNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("pendingNotifyPlayerAboutTransition")] 
		public CBool PendingNotifyPlayerAboutTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityAreaControllerPS()
		{
			RevealDevicesGrid = false;
			TweakDBRecord = "Devices.SecurityArea";
			TweakDBDescriptionRecord = 138700257142;
			UsersInPerimeter = new();
			SecurityAreaType = Enums.ESecurityAreaType.DANGEROUS;
			EventsFilters = new EventsFilters { IncomingEventsFilter = Enums.EFilterType.ALLOW_ALL, OutgoingEventsFilter = Enums.EFilterType.ALLOW_ALL };
			AreaTransitions = new();
			RuntimeTransitions = new();
			LastOutput = new OutputPersistentData { LastKnownPosition = new Vector4(), ObjectOfInterest = new entEntityID(), WhoBreached = new entEntityID(), Reporter = new gamePersistentID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
