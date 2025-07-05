using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkTierHighlight : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public CFloat Position
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PerkTierHighlight()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
