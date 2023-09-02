using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gamePuppetReplicatedState : netIEntityState
	{
		[Ordinal(2)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(3)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("initialAppearance")] 
		public CName InitialAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("actionsBuffer")] 
		public gameActionsReplicationBuffer ActionsBuffer
		{
			get => GetPropertyValue<gameActionsReplicationBuffer>();
			set => SetPropertyValue<gameActionsReplicationBuffer>(value);
		}

		[Ordinal(6)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("armor")] 
		public CFloat Armor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("hasCPOMissionData")] 
		public CBool HasCPOMissionData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("CPOMissionVotedHistory")] 
		public CArray<CName> CPOMissionVotedHistory
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(10)] 
		[RED("animEventsState")] 
		public gameReplicatedAnimControllerEventsState AnimEventsState
		{
			get => GetPropertyValue<gameReplicatedAnimControllerEventsState>();
			set => SetPropertyValue<gameReplicatedAnimControllerEventsState>(value);
		}

		[Ordinal(11)] 
		[RED("entityEventsState")] 
		public gameReplicatedEntityEventsState EntityEventsState
		{
			get => GetPropertyValue<gameReplicatedEntityEventsState>();
			set => SetPropertyValue<gameReplicatedEntityEventsState>(value);
		}

		public gamePuppetReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
