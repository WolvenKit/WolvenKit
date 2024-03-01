using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleVisualCustomizationAppearanceChange : redEvent
	{
		[Ordinal(0)] 
		[RED("val")] 
		public CBool Val
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleVisualCustomizationAppearanceChange()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
