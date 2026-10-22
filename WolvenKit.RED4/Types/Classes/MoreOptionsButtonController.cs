using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MoreOptionsButtonController : DropdownButtonController
	{
		[Ordinal(5)] 
		[RED("arrowFill")] 
		public inkImageWidgetReference ArrowFill
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buttonText")] 
		public inkTextWidgetReference ButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("buttonIcon")] 
		public inkImageWidgetReference ButtonIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("buttonCore")] 
		public inkWidgetReference ButtonCore
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("buttonBorder")] 
		public inkWidgetReference ButtonBorder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ownerWidget")] 
		public CWeakHandle<ModDetailsItem> OwnerWidget
		{
			get => GetPropertyValue<CWeakHandle<ModDetailsItem>>();
			set => SetPropertyValue<CWeakHandle<ModDetailsItem>>(value);
		}

		[Ordinal(11)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(12)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		[Ordinal(13)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MoreOptionsButtonController()
		{
			ArrowFill = new inkImageWidgetReference();
			ButtonText = new inkTextWidgetReference();
			ButtonIcon = new inkImageWidgetReference();
			ButtonCore = new inkWidgetReference();
			ButtonBorder = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
