using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTooltipSlotData : inkUserData
	{
		[Ordinal(0)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(1)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get => GetPropertyValue<CEnum<gameuiETooltipPlacement>>();
			set => SetPropertyValue<CEnum<gameuiETooltipPlacement>>(value);
		}

		public gameuiTooltipSlotData()
		{
			Margin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
