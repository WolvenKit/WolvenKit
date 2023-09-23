using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocPerkTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("ripperdocHoverState")] 
		public CEnum<RipperdocHoverState> RipperdocHoverState
		{
			get => GetPropertyValue<CEnum<RipperdocHoverState>>();
			set => SetPropertyValue<CEnum<RipperdocHoverState>>(value);
		}

		public RipperdocPerkTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
