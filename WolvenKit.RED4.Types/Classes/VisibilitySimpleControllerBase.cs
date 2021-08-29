using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VisibilitySimpleControllerBase : inkWidgetLogicController
	{
		private CArray<CName> _affectedWidgets;
		private CBool _isVisible;
		private CWeakHandle<inkWidget> _widget;

		[Ordinal(1)] 
		[RED("affectedWidgets")] 
		public CArray<CName> AffectedWidgets
		{
			get => GetProperty(ref _affectedWidgets);
			set => SetProperty(ref _affectedWidgets, value);
		}

		[Ordinal(2)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}
	}
}
