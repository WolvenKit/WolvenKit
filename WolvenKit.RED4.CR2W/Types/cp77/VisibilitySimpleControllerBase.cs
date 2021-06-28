using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VisibilitySimpleControllerBase : inkWidgetLogicController
	{
		private CArray<CName> _affectedWidgets;
		private CBool _isVisible;
		private wCHandle<inkWidget> _widget;

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
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		public VisibilitySimpleControllerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
