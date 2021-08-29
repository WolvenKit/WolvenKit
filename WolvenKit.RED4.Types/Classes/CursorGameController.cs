using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CursorGameController : gameuiWidgetGameController
	{
		private CWeakHandle<CursorRootController> _cursorRoot;
		private CName _currentContext;
		private inkMargin _margin;
		private CHandle<MenuCursorUserData> _data;
		private CBool _isCursorVisible;

		[Ordinal(2)] 
		[RED("cursorRoot")] 
		public CWeakHandle<CursorRootController> CursorRoot
		{
			get => GetProperty(ref _cursorRoot);
			set => SetProperty(ref _cursorRoot, value);
		}

		[Ordinal(3)] 
		[RED("currentContext")] 
		public CName CurrentContext
		{
			get => GetProperty(ref _currentContext);
			set => SetProperty(ref _currentContext, value);
		}

		[Ordinal(4)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<MenuCursorUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(6)] 
		[RED("isCursorVisible")] 
		public CBool IsCursorVisible
		{
			get => GetProperty(ref _isCursorVisible);
			set => SetProperty(ref _isCursorVisible, value);
		}
	}
}
