using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MainMenuTooltipData : IScriptable
	{
		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<ATooltipData> Data
		{
			get => GetPropertyValue<CHandle<ATooltipData>>();
			set => SetPropertyValue<CHandle<ATooltipData>>(value);
		}

		[Ordinal(2)] 
		[RED("targetWidget")] 
		public CWeakHandle<inkWidget> TargetWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get => GetPropertyValue<CEnum<gameuiETooltipPlacement>>();
			set => SetPropertyValue<CEnum<gameuiETooltipPlacement>>(value);
		}

		public MainMenuTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
