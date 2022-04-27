using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAcousticZoneParameterMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("param")] 
		public CName Param
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAcousticZoneParameterMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
