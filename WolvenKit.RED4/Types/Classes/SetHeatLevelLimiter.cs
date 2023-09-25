using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetHeatLevelLimiter : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("HeatLevelMin")] 
		public CInt32 HeatLevelMin
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("HeatLevelMax")] 
		public CInt32 HeatLevelMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("HeatLevelReset")] 
		public CBool HeatLevelReset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetHeatLevelLimiter()
		{
			HeatLevelMax = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
