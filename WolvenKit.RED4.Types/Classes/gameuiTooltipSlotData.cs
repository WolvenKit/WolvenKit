using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTooltipSlotData : inkUserData
	{
		private inkMargin _margin;
		private CEnum<gameuiETooltipPlacement> _placement;

		[Ordinal(0)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(1)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}
	}
}
