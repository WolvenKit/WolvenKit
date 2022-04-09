using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayEnv_SetWeather : questIEnvironmentManagerNodeType
	{
		[Ordinal(0)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("weatherID")] 
		public TweakDBID WeatherID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questPlayEnv_SetWeather()
		{
			BlendTime = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
