using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledEffectEventInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("eventRUID")] 
		public CRUID EventRUID
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("placementIndexMask")] 
		public CUInt64 PlacementIndexMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("componentIndexMask")] 
		public CUInt64 ComponentIndexMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldCompiledEffectEventInfo()
		{
			Flags = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
