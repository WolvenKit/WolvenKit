using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppetReplicatedState : netIEntityState
	{
		private EulerAngles _initialOrientation;
		private Vector3 _initialLocation;
		private CName _initialAppearance;
		private gameActionsReplicationBuffer _actionsBuffer;
		private CFloat _health;
		private CFloat _armor;
		private CBool _hasCPOMissionData;
		private CArray<CName> _cPOMissionVotedHistory;
		private gameReplicatedAnimControllerEventsState _animEventsState;
		private gameReplicatedEntityEventsState _entityEventsState;

		[Ordinal(2)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetProperty(ref _initialOrientation);
			set => SetProperty(ref _initialOrientation, value);
		}

		[Ordinal(3)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetProperty(ref _initialLocation);
			set => SetProperty(ref _initialLocation, value);
		}

		[Ordinal(4)] 
		[RED("initialAppearance")] 
		public CName InitialAppearance
		{
			get => GetProperty(ref _initialAppearance);
			set => SetProperty(ref _initialAppearance, value);
		}

		[Ordinal(5)] 
		[RED("actionsBuffer")] 
		public gameActionsReplicationBuffer ActionsBuffer
		{
			get => GetProperty(ref _actionsBuffer);
			set => SetProperty(ref _actionsBuffer, value);
		}

		[Ordinal(6)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		[Ordinal(7)] 
		[RED("armor")] 
		public CFloat Armor
		{
			get => GetProperty(ref _armor);
			set => SetProperty(ref _armor, value);
		}

		[Ordinal(8)] 
		[RED("hasCPOMissionData")] 
		public CBool HasCPOMissionData
		{
			get => GetProperty(ref _hasCPOMissionData);
			set => SetProperty(ref _hasCPOMissionData, value);
		}

		[Ordinal(9)] 
		[RED("CPOMissionVotedHistory")] 
		public CArray<CName> CPOMissionVotedHistory
		{
			get => GetProperty(ref _cPOMissionVotedHistory);
			set => SetProperty(ref _cPOMissionVotedHistory, value);
		}

		[Ordinal(10)] 
		[RED("animEventsState")] 
		public gameReplicatedAnimControllerEventsState AnimEventsState
		{
			get => GetProperty(ref _animEventsState);
			set => SetProperty(ref _animEventsState, value);
		}

		[Ordinal(11)] 
		[RED("entityEventsState")] 
		public gameReplicatedEntityEventsState EntityEventsState
		{
			get => GetProperty(ref _entityEventsState);
			set => SetProperty(ref _entityEventsState, value);
		}
	}
}
