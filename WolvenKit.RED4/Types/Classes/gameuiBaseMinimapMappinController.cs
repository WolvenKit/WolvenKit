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
			IconWidget = new inkImageWidgetReference();
			PlayerTrackedWidget = new inkWidgetReference();
			ScaleWidget = new inkWidgetReference();
			AnimPlayerTrackedWidget = new inkWidgetReference();
			AnimPlayerAboveBelowWidget = new inkWidgetReference();
			TaggedWidgets = new();
			FixedOrientationWidget = new inkWidgetReference();
			ClampArrowWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
