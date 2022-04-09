using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeLeapEvents : MeleeEventsTransition
	{
		[Ordinal(1)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public MeleeLeapEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
