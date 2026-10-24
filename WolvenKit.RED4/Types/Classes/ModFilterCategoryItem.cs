using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModFilterCategoryItem : DrawerNavigableItem
	{
		[Ordinal(16)] 
		[RED("filterNameText")] 
		public inkTextWidgetReference FilterNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("selectorCanvas")] 
		public inkWidgetReference SelectorCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("checkboxFill")] 
		public inkImageWidgetReference CheckboxFill
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("checkboxOutline")] 
		public inkImageWidgetReference CheckboxOutline
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("panelBackground")] 
		public inkWidgetReference PanelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("panelOutline")] 
		public inkWidgetReference PanelOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("filterName")] 
		public CString FilterName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(23)] 
		[RED("localizedFilterName")] 
		public CString LocalizedFilterName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(24)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isCurrentlyHovered")] 
		public CBool IsCurrentlyHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("ownerFolder")] 
		public CWeakHandle<ModFilterCategoryFolder> OwnerFolder
		{
			get => GetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>();
			set => SetPropertyValue<CWeakHandle<ModFilterCategoryFolder>>(value);
		}

		[Ordinal(28)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public ModFilterCategoryItem()
		{
			FilterNameText = new inkTextWidgetReference();
			SelectorCanvas = new inkWidgetReference();
			CheckboxFill = new inkImageWidgetReference();
			CheckboxOutline = new inkImageWidgetReference();
			PanelBackground = new inkWidgetReference();
			PanelOutline = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
