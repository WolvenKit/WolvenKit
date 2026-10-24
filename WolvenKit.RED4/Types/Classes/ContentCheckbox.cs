using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ContentCheckbox : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("checkboxCanvas")] 
		public inkWidgetReference CheckboxCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("checkboxImage")] 
		public inkImageWidgetReference CheckboxImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("checkboxText")] 
		public inkTextWidgetReference CheckboxText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("bState")] 
		public CBool BState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(38)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public ContentCheckbox()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
