using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		[Ordinal(7)] 
		[RED("iconOrientation")] 
		public CEnum<gameuiEIconOrientation> IconOrientation
		{
			get => GetPropertyValue<CEnum<gameuiEIconOrientation>>();
			set => SetPropertyValue<CEnum<gameuiEIconOrientation>>(value);
		}

		[Ordinal(8)] 
		[RED("fixedOrientationWidget")] 
		public inkWidgetReference FixedOrientationWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("clampArrowWidget")] 
		public inkWidgetReference ClampArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("aboveWidget")] 
		public CWeakHandle<inkWidget> AboveWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("belowWidget")] 
		public CWeakHandle<inkWidget> BelowWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public gameuiBaseMinimapMappinController()
		{
			IconWidget = new();
			PlayerTrackedWidget = new();
			ScaleWidget = new();
			AnimPlayerTrackedWidget = new();
			AnimPlayerAboveBelowWidget = new();
			TaggedWidgets = new();
			FixedOrientationWidget = new();
			ClampArrowWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
