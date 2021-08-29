using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAdvertLightColorPickerController : inkWidgetLogicController
	{
		private CColor _lightColor;

		[Ordinal(1)] 
		[RED("lightColor")] 
		public CColor LightColor
		{
			get => GetProperty(ref _lightColor);
			set => SetProperty(ref _lightColor, value);
		}
	}
}
