using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ListItemsGroupController : CodexListItemController
	{
		[Ordinal(22)] 
		[RED("menuList")] 
		public inkCompoundWidgetReference MenuList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("foldArrowRef")] 
		public inkWidgetReference FoldArrowRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("foldoutButton")] 
		public inkWidgetReference FoldoutButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("foldoutIndipendently")] 
		public CBool FoldoutIndipendently
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("menuListController")] 
		public CWeakHandle<inkListController> MenuListController
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(27)] 
		[RED("foldoutButtonController")] 
		public CWeakHandle<inkButtonController> FoldoutButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(28)] 
		[RED("lastClickedData")] 
		public CWeakHandle<IScriptable> LastClickedData
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(29)] 
		[RED("data")] 
		public CArray<CHandle<IScriptable>> Data
		{
			get => GetPropertyValue<CArray<CHandle<IScriptable>>>();
			set => SetPropertyValue<CArray<CHandle<IScriptable>>>(value);
		}

		[Ordinal(30)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ListItemsGroupController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
