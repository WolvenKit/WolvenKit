using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareTooltipSlotListItem : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<CyberwareSlotTooltipData> Data
		{
			get => GetPropertyValue<CHandle<CyberwareSlotTooltipData>>();
			set => SetPropertyValue<CHandle<CyberwareSlotTooltipData>>(value);
		}

		public CyberwareTooltipSlotListItem()
		{
			Icon = new();
			Label = new();
			Desc = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
