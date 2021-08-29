using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAcousticConstantsPreset : audioAudioMetadata
	{
		private CFloat _dopplerFactor;
		private CFloat _speedOfSound;
		private CFloat _wideInteriorLimit;
		private CFloat _enclosedCeilingDistance;
		private CFloat _urbanNarrowDistance;
		private CFloat _urbanStreetDistance;
		private CFloat _exteriorWideAltitude;
		private CFloat _elevatedOpenDistance;
		private CFloat _ambExteriorCeilingMinDistance;
		private CFloat _ambExteriorCeilingMaxDistance;
		private CFloat _badlandsWideRelativeAltitude;
		private CFloat _repositioningStandardZoomFactor;
		private CFloat _repositioningScanningZoomFactor;
		private CFloat _repositioningVoStandardZoomFactor;
		private CFloat _repositioningVoScanningZoomFactor;
		private CArray<CName> _groupingExcludedVisualTags;
		private CName _windowEventName;
		private CFloat _maxWindowOffset;

		[Ordinal(1)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get => GetProperty(ref _dopplerFactor);
			set => SetProperty(ref _dopplerFactor, value);
		}

		[Ordinal(2)] 
		[RED("speedOfSound")] 
		public CFloat SpeedOfSound
		{
			get => GetProperty(ref _speedOfSound);
			set => SetProperty(ref _speedOfSound, value);
		}

		[Ordinal(3)] 
		[RED("wideInteriorLimit")] 
		public CFloat WideInteriorLimit
		{
			get => GetProperty(ref _wideInteriorLimit);
			set => SetProperty(ref _wideInteriorLimit, value);
		}

		[Ordinal(4)] 
		[RED("enclosedCeilingDistance")] 
		public CFloat EnclosedCeilingDistance
		{
			get => GetProperty(ref _enclosedCeilingDistance);
			set => SetProperty(ref _enclosedCeilingDistance, value);
		}

		[Ordinal(5)] 
		[RED("urbanNarrowDistance")] 
		public CFloat UrbanNarrowDistance
		{
			get => GetProperty(ref _urbanNarrowDistance);
			set => SetProperty(ref _urbanNarrowDistance, value);
		}

		[Ordinal(6)] 
		[RED("urbanStreetDistance")] 
		public CFloat UrbanStreetDistance
		{
			get => GetProperty(ref _urbanStreetDistance);
			set => SetProperty(ref _urbanStreetDistance, value);
		}

		[Ordinal(7)] 
		[RED("exteriorWideAltitude")] 
		public CFloat ExteriorWideAltitude
		{
			get => GetProperty(ref _exteriorWideAltitude);
			set => SetProperty(ref _exteriorWideAltitude, value);
		}

		[Ordinal(8)] 
		[RED("elevatedOpenDistance")] 
		public CFloat ElevatedOpenDistance
		{
			get => GetProperty(ref _elevatedOpenDistance);
			set => SetProperty(ref _elevatedOpenDistance, value);
		}

		[Ordinal(9)] 
		[RED("ambExteriorCeilingMinDistance")] 
		public CFloat AmbExteriorCeilingMinDistance
		{
			get => GetProperty(ref _ambExteriorCeilingMinDistance);
			set => SetProperty(ref _ambExteriorCeilingMinDistance, value);
		}

		[Ordinal(10)] 
		[RED("ambExteriorCeilingMaxDistance")] 
		public CFloat AmbExteriorCeilingMaxDistance
		{
			get => GetProperty(ref _ambExteriorCeilingMaxDistance);
			set => SetProperty(ref _ambExteriorCeilingMaxDistance, value);
		}

		[Ordinal(11)] 
		[RED("badlandsWideRelativeAltitude")] 
		public CFloat BadlandsWideRelativeAltitude
		{
			get => GetProperty(ref _badlandsWideRelativeAltitude);
			set => SetProperty(ref _badlandsWideRelativeAltitude, value);
		}

		[Ordinal(12)] 
		[RED("repositioningStandardZoomFactor")] 
		public CFloat RepositioningStandardZoomFactor
		{
			get => GetProperty(ref _repositioningStandardZoomFactor);
			set => SetProperty(ref _repositioningStandardZoomFactor, value);
		}

		[Ordinal(13)] 
		[RED("repositioningScanningZoomFactor")] 
		public CFloat RepositioningScanningZoomFactor
		{
			get => GetProperty(ref _repositioningScanningZoomFactor);
			set => SetProperty(ref _repositioningScanningZoomFactor, value);
		}

		[Ordinal(14)] 
		[RED("repositioningVoStandardZoomFactor")] 
		public CFloat RepositioningVoStandardZoomFactor
		{
			get => GetProperty(ref _repositioningVoStandardZoomFactor);
			set => SetProperty(ref _repositioningVoStandardZoomFactor, value);
		}

		[Ordinal(15)] 
		[RED("repositioningVoScanningZoomFactor")] 
		public CFloat RepositioningVoScanningZoomFactor
		{
			get => GetProperty(ref _repositioningVoScanningZoomFactor);
			set => SetProperty(ref _repositioningVoScanningZoomFactor, value);
		}

		[Ordinal(16)] 
		[RED("groupingExcludedVisualTags")] 
		public CArray<CName> GroupingExcludedVisualTags
		{
			get => GetProperty(ref _groupingExcludedVisualTags);
			set => SetProperty(ref _groupingExcludedVisualTags, value);
		}

		[Ordinal(17)] 
		[RED("windowEventName")] 
		public CName WindowEventName
		{
			get => GetProperty(ref _windowEventName);
			set => SetProperty(ref _windowEventName, value);
		}

		[Ordinal(18)] 
		[RED("maxWindowOffset")] 
		public CFloat MaxWindowOffset
		{
			get => GetProperty(ref _maxWindowOffset);
			set => SetProperty(ref _maxWindowOffset, value);
		}
	}
}
