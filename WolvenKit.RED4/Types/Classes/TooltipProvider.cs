using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TooltipProvider : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("TooltipsData")] 
		public CArray<CHandle<ATooltipData>> TooltipsData
		{
			get => GetPropertyValue<CArray<CHandle<ATooltipData>>>();
			set => SetPropertyValue<CArray<CHandle<ATooltipData>>>(value);
		}

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TooltipProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
