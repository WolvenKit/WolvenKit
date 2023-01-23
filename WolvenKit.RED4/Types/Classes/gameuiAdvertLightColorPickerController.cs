using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiAdvertLightColorPickerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("lightColor")] 
		public CColor LightColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public gameuiAdvertLightColorPickerController()
		{
			LightColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
