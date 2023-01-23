using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("slotList")] 
		public inkCompoundWidgetReference SlotList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<CyberwareTooltipData> Data
		{
			get => GetPropertyValue<CHandle<CyberwareTooltipData>>();
			set => SetPropertyValue<CHandle<CyberwareTooltipData>>(value);
		}

		public CyberwareTooltip()
		{
			SlotList = new();
			Label = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
