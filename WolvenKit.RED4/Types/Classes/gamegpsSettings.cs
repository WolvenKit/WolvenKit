using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamegpsSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lineEffectOnFoot")] 
		public CResourceAsyncReference<worldEffect> LineEffectOnFoot
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(1)] 
		[RED("lineEffectVehicle")] 
		public CResourceAsyncReference<worldEffect> LineEffectVehicle
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(2)] 
		[RED("fixedPathOffset")] 
		public Vector3 FixedPathOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("fixedPortalMappinOffset")] 
		public Vector3 FixedPortalMappinOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("pathRefreshTimeInterval")] 
		public CFloat PathRefreshTimeInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("lastPlayerNavmeshPositionRefreshTimeIntervalSecs")] 
		public CFloat LastPlayerNavmeshPositionRefreshTimeIntervalSecs
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxPathDisplayLength")] 
		public CFloat MaxPathDisplayLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamegpsSettings()
		{
			FixedPathOffset = new() { Z = 0.500000F };
			FixedPortalMappinOffset = new() { Z = 1.250000F };
			PathRefreshTimeInterval = 1.000000F;
			LastPlayerNavmeshPositionRefreshTimeIntervalSecs = 0.330000F;
			MaxPathDisplayLength = 400.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
