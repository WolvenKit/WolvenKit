using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LanguageDropdownCheckboxElementController : DropdownElementController
	{
		[Ordinal(11)] 
		[RED("languageCheckboxRef")] 
		public inkWidgetReference LanguageCheckboxRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("frameWidget")] 
		public inkWidgetReference FrameWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(14)] 
		[RED("languageCheckboxController")] 
		public CWeakHandle<LanguageCheckbox> LanguageCheckboxController
		{
			get => GetPropertyValue<CWeakHandle<LanguageCheckbox>>();
			set => SetPropertyValue<CWeakHandle<LanguageCheckbox>>(value);
		}

		[Ordinal(15)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public LanguageDropdownCheckboxElementController()
		{
			LanguageCheckboxRef = new inkWidgetReference();
			FrameWidget = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
