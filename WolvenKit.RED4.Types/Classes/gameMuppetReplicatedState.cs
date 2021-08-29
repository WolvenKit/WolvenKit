using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetReplicatedState : netIEntityState
	{
		private gameMuppetState _state;
		private EulerAngles _initialOrientation;
		private Vector3 _initialLocation;
		private CFloat _health;
		private CFloat _armor;

		[Ordinal(2)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(3)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetProperty(ref _initialOrientation);
			set => SetProperty(ref _initialOrientation, value);
		}

		[Ordinal(4)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetProperty(ref _initialLocation);
			set => SetProperty(ref _initialLocation, value);
		}

		[Ordinal(5)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		[Ordinal(6)] 
		[RED("armor")] 
		public CFloat Armor
		{
			get => GetProperty(ref _armor);
			set => SetProperty(ref _armor, value);
		}
	}
}
