using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleePublicSafeEvents : MeleeRumblingEvents
	{
		[Ordinal(1)] 
		[RED("unequipTime")] 
		public CFloat UnequipTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MeleePublicSafeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
