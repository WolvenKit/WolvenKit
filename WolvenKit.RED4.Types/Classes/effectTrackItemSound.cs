using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemSound : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetPropertyValue<CArray<audioAudSwitch>>();
			set => SetPropertyValue<CArray<audioAudSwitch>>(value);
		}

		[Ordinal(5)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetPropertyValue<CArray<audioAudParameter>>();
			set => SetPropertyValue<CArray<audioAudParameter>>(value);
		}

		[Ordinal(6)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("rtpcName")] 
		public CName RtpcName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("rtpcValue")] 
		public CHandle<IEvaluatorFloat> RtpcValue
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public effectTrackItemSound()
		{
			TimeDuration = 1.000000F;
			Switches = new();
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
