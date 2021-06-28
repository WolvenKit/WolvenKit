using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		private CEnum<gameuiEIconOrientation> _iconOrientation;
		private inkWidgetReference _fixedOrientationWidget;
		private inkWidgetReference _clampArrowWidget;
		private wCHandle<gamemappinsIMappin> _mappin;
		private wCHandle<inkWidget> _root;
		private wCHandle<inkWidget> _aboveWidget;
		private wCHandle<inkWidget> _belowWidget;

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
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(12)] 
		[RED("aboveWidget")] 
		public wCHandle<inkWidget> AboveWidget
		{
			get => GetProperty(ref _aboveWidget);
			set => SetProperty(ref _aboveWidget, value);
		}

		[Ordinal(13)] 
		[RED("belowWidget")] 
		public wCHandle<inkWidget> BelowWidget
		{
			get => GetProperty(ref _belowWidget);
			set => SetProperty(ref _belowWidget, value);
		}

		public gameuiBaseMinimapMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
