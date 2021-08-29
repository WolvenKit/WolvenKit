using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapDeviceMappinController : gameuiBaseMinimapMappinController
	{
		private inkCircleWidgetReference _effectAreaWidget;

		[Ordinal(14)] 
		[RED("effectAreaWidget")] 
		public inkCircleWidgetReference EffectAreaWidget
		{
			get => GetProperty(ref _effectAreaWidget);
			set => SetProperty(ref _effectAreaWidget, value);
		}
	}
}
