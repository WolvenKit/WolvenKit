using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SharedGameplayPS : gameDeviceComponentPS
	{
		private CEnum<EDeviceStatus> _deviceState;
		private AuthorizationData _authorizationProperties;
		private CBool _wasStateCached;
		private CBool _wasStateSet;
		private CEnum<EDeviceStatus> _cachedDeviceState;
		private CBool _revealDevicesGrid;
		private CBool _revealDevicesGridWhenUnpowered;
		private CBool _wasRevealedInNetworkPing;
		private CBool _hasNetworkBackdoor;

		[Ordinal(13)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetProperty(ref _deviceState);
			set => SetProperty(ref _deviceState, value);
		}

		[Ordinal(14)] 
		[RED("authorizationProperties")] 
		public AuthorizationData AuthorizationProperties
		{
			get => GetProperty(ref _authorizationProperties);
			set => SetProperty(ref _authorizationProperties, value);
		}

		[Ordinal(15)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetProperty(ref _wasStateCached);
			set => SetProperty(ref _wasStateCached, value);
		}

		[Ordinal(16)] 
		[RED("wasStateSet")] 
		public CBool WasStateSet
		{
			get => GetProperty(ref _wasStateSet);
			set => SetProperty(ref _wasStateSet, value);
		}

		[Ordinal(17)] 
		[RED("cachedDeviceState")] 
		public CEnum<EDeviceStatus> CachedDeviceState
		{
			get => GetProperty(ref _cachedDeviceState);
			set => SetProperty(ref _cachedDeviceState, value);
		}

		[Ordinal(18)] 
		[RED("revealDevicesGrid")] 
		public CBool RevealDevicesGrid
		{
			get => GetProperty(ref _revealDevicesGrid);
			set => SetProperty(ref _revealDevicesGrid, value);
		}

		[Ordinal(19)] 
		[RED("revealDevicesGridWhenUnpowered")] 
		public CBool RevealDevicesGridWhenUnpowered
		{
			get => GetProperty(ref _revealDevicesGridWhenUnpowered);
			set => SetProperty(ref _revealDevicesGridWhenUnpowered, value);
		}

		[Ordinal(20)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get => GetProperty(ref _wasRevealedInNetworkPing);
			set => SetProperty(ref _wasRevealedInNetworkPing, value);
		}

		[Ordinal(21)] 
		[RED("hasNetworkBackdoor")] 
		public CBool HasNetworkBackdoor
		{
			get => GetProperty(ref _hasNetworkBackdoor);
			set => SetProperty(ref _hasNetworkBackdoor, value);
		}
	}
}
