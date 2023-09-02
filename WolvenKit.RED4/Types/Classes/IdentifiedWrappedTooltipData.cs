using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IdentifiedWrappedTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("tooltipOwner")] 
		public entEntityID TooltipOwner
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CHandle<ATooltipData> Data
		{
			get => GetPropertyValue<CHandle<ATooltipData>>();
			set => SetPropertyValue<CHandle<ATooltipData>>(value);
		}

		public IdentifiedWrappedTooltipData()
		{
			TooltipOwner = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
