using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleComponentWithCounterPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SampleComponentWithCounterPS()
		{
			Counter = 1000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
