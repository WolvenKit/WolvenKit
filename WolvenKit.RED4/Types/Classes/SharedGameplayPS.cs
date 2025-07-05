using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SharedGameplayPS : gameDeviceComponentPS
	{
		[Ordinal(14)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(15)] 
		[RED("authorizationProperties")] 
		public AuthorizationData AuthorizationProperties
		{
			get => GetPropertyValue<AuthorizationData>();
			set => SetPropertyValue<AuthorizationData>(value);
		}

		[Ordinal(16)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("wasStateSet")] 
		public CBool WasStateSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("cachedDeviceState")] 
		public CEnum<EDeviceStatus> CachedDeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(19)] 
		[RED("revealDevicesGrid")] 
		public CBool RevealDevicesGrid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("revealDevicesGridWhenUnpowered")] 
		public CBool RevealDevicesGridWhenUnpowered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("hasNetworkBackdoor")] 
		public CBool HasNetworkBackdoor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SharedGameplayPS()
		{
			AuthorizationProperties = new AuthorizationData { IsAuthorizationModuleOn = true, AuthorizationDataEntry = new SecurityAccessLevelEntryClient() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
