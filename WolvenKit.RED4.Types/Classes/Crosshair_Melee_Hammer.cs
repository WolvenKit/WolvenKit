using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Melee_Hammer : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public Crosshair_Melee_Hammer()
		{
			TargetColorChange = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
