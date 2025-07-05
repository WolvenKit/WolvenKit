using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopUint64Pair : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("first")] 
		public CUInt64 First
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("second")] 
		public CUInt64 Second
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public interopUint64Pair()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
