using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinBaseController : inkWidgetLogicController
	{
		private inkImageWidgetReference _iconWidget;
		private inkWidgetReference _playerTrackedWidget;
		private inkWidgetReference _scaleWidget;
		private inkWidgetReference _animPlayerTrackedWidget;
		private inkWidgetReference _animPlayerAboveBelowWidget;
		private CArray<inkWidgetReference> _taggedWidgets;

		[Ordinal(1)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetProperty(ref _iconWidget);
			set => SetProperty(ref _iconWidget, value);
		}

		[Ordinal(2)] 
		[RED("playerTrackedWidget")] 
		public inkWidgetReference PlayerTrackedWidget
		{
			get => GetProperty(ref _playerTrackedWidget);
			set => SetProperty(ref _playerTrackedWidget, value);
		}

		[Ordinal(3)] 
		[RED("scaleWidget")] 
		public inkWidgetReference ScaleWidget
		{
			get => GetProperty(ref _scaleWidget);
			set => SetProperty(ref _scaleWidget, value);
		}

		[Ordinal(4)] 
		[RED("animPlayerTrackedWidget")] 
		public inkWidgetReference AnimPlayerTrackedWidget
		{
			get => GetProperty(ref _animPlayerTrackedWidget);
			set => SetProperty(ref _animPlayerTrackedWidget, value);
		}

		[Ordinal(5)] 
		[RED("animPlayerAboveBelowWidget")] 
		public inkWidgetReference AnimPlayerAboveBelowWidget
		{
			get => GetProperty(ref _animPlayerAboveBelowWidget);
			set => SetProperty(ref _animPlayerAboveBelowWidget, value);
		}

		[Ordinal(6)] 
		[RED("taggedWidgets")] 
		public CArray<inkWidgetReference> TaggedWidgets
		{
			get => GetProperty(ref _taggedWidgets);
			set => SetProperty(ref _taggedWidgets, value);
		}

		public gameuiMappinBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
