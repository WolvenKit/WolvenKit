using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HubMenuLabelContentContainer : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("desiredSizeWrapper")] 
		public inkWidgetReference DesiredSizeWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("border")] 
		public inkBorderWidgetReference Border
		{
			get => GetPropertyValue<inkBorderWidgetReference>();
			set => SetPropertyValue<inkBorderWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("carouselPosition")] 
		public CInt32 CarouselPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("labelName")] 
		public CString LabelName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("data")] 
		public MenuData Data
		{
			get => GetPropertyValue<MenuData>();
			set => SetPropertyValue<MenuData>(value);
		}

		public HubMenuLabelContentContainer()
		{
			Label = new inkTextWidgetReference();
			Icon = new inkImageWidgetReference();
			DesiredSizeWrapper = new inkWidgetReference();
			Border = new inkBorderWidgetReference();
			Line = new inkWidgetReference();
			Data = new MenuData { Identifier = -1, SubMenus = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
