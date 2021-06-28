using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ListItemsGroupController : CodexListItemController
	{
		private inkCompoundWidgetReference _menuList;
		private inkWidgetReference _foldArrowRef;
		private inkWidgetReference _foldoutButton;
		private CBool _foldoutIndipendently;
		private wCHandle<inkListController> _menuListController;
		private wCHandle<inkButtonController> _foldoutButtonController;
		private wCHandle<IScriptable> _lastClickedData;
		private CArray<CHandle<IScriptable>> _data;
		private CBool _isOpen;

		[Ordinal(19)] 
		[RED("menuList")] 
		public inkCompoundWidgetReference MenuList
		{
			get => GetProperty(ref _menuList);
			set => SetProperty(ref _menuList, value);
		}

		[Ordinal(20)] 
		[RED("foldArrowRef")] 
		public inkWidgetReference FoldArrowRef
		{
			get => GetProperty(ref _foldArrowRef);
			set => SetProperty(ref _foldArrowRef, value);
		}

		[Ordinal(21)] 
		[RED("foldoutButton")] 
		public inkWidgetReference FoldoutButton
		{
			get => GetProperty(ref _foldoutButton);
			set => SetProperty(ref _foldoutButton, value);
		}

		[Ordinal(22)] 
		[RED("foldoutIndipendently")] 
		public CBool FoldoutIndipendently
		{
			get => GetProperty(ref _foldoutIndipendently);
			set => SetProperty(ref _foldoutIndipendently, value);
		}

		[Ordinal(23)] 
		[RED("menuListController")] 
		public wCHandle<inkListController> MenuListController
		{
			get => GetProperty(ref _menuListController);
			set => SetProperty(ref _menuListController, value);
		}

		[Ordinal(24)] 
		[RED("foldoutButtonController")] 
		public wCHandle<inkButtonController> FoldoutButtonController
		{
			get => GetProperty(ref _foldoutButtonController);
			set => SetProperty(ref _foldoutButtonController, value);
		}

		[Ordinal(25)] 
		[RED("lastClickedData")] 
		public wCHandle<IScriptable> LastClickedData
		{
			get => GetProperty(ref _lastClickedData);
			set => SetProperty(ref _lastClickedData, value);
		}

		[Ordinal(26)] 
		[RED("data")] 
		public CArray<CHandle<IScriptable>> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(27)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		public ListItemsGroupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
