using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewCycleEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("cyclesCount")] 
		public CUInt16 CyclesCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public NewCycleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
