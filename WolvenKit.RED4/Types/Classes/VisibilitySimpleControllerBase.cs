using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VisibilitySimpleControllerBase : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("affectedWidgets")] 
		public CArray<CName> AffectedWidgets
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public VisibilitySimpleControllerBase()
		{
			AffectedWidgets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
