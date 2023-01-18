using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapDeviceMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("effectAreaWidget")] 
		public inkCircleWidgetReference EffectAreaWidget
		{
			get => GetPropertyValue<inkCircleWidgetReference>();
			set => SetPropertyValue<inkCircleWidgetReference>(value);
		}

		public gameuiMinimapDeviceMappinController()
		{
			EffectAreaWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
