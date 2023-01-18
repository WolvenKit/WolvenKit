using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class netTime : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("milliSecs")] 
		public CUInt64 MilliSecs
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public netTime()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
