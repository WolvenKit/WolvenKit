using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		private CEnum<gameuiEIconOrientation> _iconOrientation;
		private inkWidgetReference _fixedOrientationWidget;
		private inkWidgetReference _clampArrowWidget;
		private CWeakHandle<gamemappinsIMappin> _mappin;
		private CWeakHandle<inkWidget> _root;
		private CWeakHandle<inkWidget> _aboveWidget;
		private CWeakHandle<inkWidget> _belowWidget;

		[Ordinal(7)] 
		[RED("iconOrientation")] 
		public CEnum<gameuiEIconOrientation> IconOrientation
		{
			get => GetProperty(ref _iconOrientation);
			set => SetProperty(ref _iconOrientation, value);
		}

		[Ordinal(8)] 
		[RED("fixedOrientationWidget")] 
		public inkWidgetReference FixedOrientationWidget
		{
			get => GetProperty(ref _fixedOrientationWidget);
			set => SetProperty(ref _fixedOrientationWidget, value);
		}

		[Ordinal(9)] 
		[RED("clampArrowWidget")] 
		public inkWidgetReference ClampArrowWidget
		{
			get => GetProperty(ref _clampArrowWidget);
			set => SetProperty(ref _clampArrowWidget, value);
		}

		[Ordinal(10)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(12)] 
		[RED("aboveWidget")] 
		public CWeakHandle<inkWidget> AboveWidget
		{
			get => GetProperty(ref _aboveWidget);
			set => SetProperty(ref _aboveWidget, value);
		}

		[Ordinal(13)] 
		[RED("belowWidget")] 
		public CWeakHandle<inkWidget> BelowWidget
		{
			get => GetProperty(ref _belowWidget);
			set => SetProperty(ref _belowWidget, value);
		}
	}
}
