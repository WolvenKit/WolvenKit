using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterIconItem : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("iconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("frameImage")] 
		public inkImageWidgetReference FrameImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("backgroundImage")] 
		public inkImageWidgetReference BackgroundImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("tooltipSnapPoint")] 
		public inkCompoundWidgetReference TooltipSnapPoint
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("filterTag")] 
		public CEnum<inkModioFilterTags> FilterTag
		{
			get => GetPropertyValue<CEnum<inkModioFilterTags>>();
			set => SetPropertyValue<CEnum<inkModioFilterTags>>(value);
		}

		[Ordinal(40)] 
		[RED("filterTagName")] 
		public CString FilterTagName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(41)] 
		[RED("currentTexturePart")] 
		public CName CurrentTexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		[Ordinal(43)] 
		[RED("tooltipWidget")] 
		public CWeakHandle<inkWidget> TooltipWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(44)] 
		[RED("tooltipController")] 
		public CWeakHandle<ModioToolTipController> TooltipController
		{
			get => GetPropertyValue<CWeakHandle<ModioToolTipController>>();
			set => SetPropertyValue<CWeakHandle<ModioToolTipController>>(value);
		}

		[Ordinal(45)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public FilterIconItem()
		{
			IconImage = new inkImageWidgetReference();
			FluffText = new inkTextWidgetReference();
			FrameImage = new inkImageWidgetReference();
			BackgroundImage = new inkImageWidgetReference();
			TooltipSnapPoint = new inkCompoundWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
