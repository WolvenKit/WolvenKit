using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAcousticConstantsPreset : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("speedOfSound")] 
		public CFloat SpeedOfSound
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("wideInteriorLimit")] 
		public CFloat WideInteriorLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("enclosedCeilingDistance")] 
		public CFloat EnclosedCeilingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("urbanNarrowDistance")] 
		public CFloat UrbanNarrowDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("urbanStreetDistance")] 
		public CFloat UrbanStreetDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("exteriorWideAltitude")] 
		public CFloat ExteriorWideAltitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("elevatedOpenDistance")] 
		public CFloat ElevatedOpenDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("ambExteriorCeilingMinDistance")] 
		public CFloat AmbExteriorCeilingMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("ambExteriorCeilingMaxDistance")] 
		public CFloat AmbExteriorCeilingMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("badlandsWideRelativeAltitude")] 
		public CFloat BadlandsWideRelativeAltitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("repositioningStandardZoomFactor")] 
		public CFloat RepositioningStandardZoomFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("repositioningScanningZoomFactor")] 
		public CFloat RepositioningScanningZoomFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("repositioningVoStandardZoomFactor")] 
		public CFloat RepositioningVoStandardZoomFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("repositioningVoScanningZoomFactor")] 
		public CFloat RepositioningVoScanningZoomFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("groupingExcludedVisualTags")] 
		public CArray<CName> GroupingExcludedVisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(17)] 
		[RED("windowEventName")] 
		public CName WindowEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("maxWindowOffset")] 
		public CFloat MaxWindowOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAcousticConstantsPreset()
		{
			DopplerFactor = 1.000000F;
			SpeedOfSound = 343.000000F;
			WideInteriorLimit = 10.000000F;
			EnclosedCeilingDistance = 20.000000F;
			UrbanNarrowDistance = 10.000000F;
			UrbanStreetDistance = 25.000000F;
			ExteriorWideAltitude = 50.000000F;
			ElevatedOpenDistance = 40.000000F;
			AmbExteriorCeilingMinDistance = 3.000000F;
			AmbExteriorCeilingMaxDistance = 20.000000F;
			BadlandsWideRelativeAltitude = 12.000000F;
			RepositioningStandardZoomFactor = 0.250000F;
			RepositioningScanningZoomFactor = 1.000000F;
			RepositioningVoStandardZoomFactor = 1.000000F;
			RepositioningVoScanningZoomFactor = 1.000000F;
			GroupingExcludedVisualTags = new();
			MaxWindowOffset = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
