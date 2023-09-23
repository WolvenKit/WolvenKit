using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetHeatCounterMultiplier : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("heatMultiplier")] 
		public CFloat HeatMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetHeatCounterMultiplier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
