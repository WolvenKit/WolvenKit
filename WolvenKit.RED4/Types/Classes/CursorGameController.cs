using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CursorGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("cursorRoot")] 
		public CWeakHandle<CursorRootController> CursorRoot
		{
			get => GetPropertyValue<CWeakHandle<CursorRootController>>();
			set => SetPropertyValue<CWeakHandle<CursorRootController>>(value);
		}

		[Ordinal(3)] 
		[RED("currentContext")] 
		public CName CurrentContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<MenuCursorUserData> Data
		{
			get => GetPropertyValue<CHandle<MenuCursorUserData>>();
			set => SetPropertyValue<CHandle<MenuCursorUserData>>(value);
		}

		[Ordinal(6)] 
		[RED("isCursorVisible")] 
		public CBool IsCursorVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("cursorType")] 
		public CName CursorType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("cursorForDevice")] 
		public CName CursorForDevice
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CursorGameController()
		{
			Margin = new inkMargin();
			CursorType = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
