using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAcousticConstantsPreset : audioAudioMetadata
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
			get
			{
				if (_dopplerFactor == null)
				{
					_dopplerFactor = (CFloat) CR2WTypeManager.Create("Float", "dopplerFactor", cr2w, this);
				}
				return _dopplerFactor;
			}
			set
			{
				if (_dopplerFactor == value)
				{
					return;
				}
				_dopplerFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speedOfSound")] 
		public CFloat SpeedOfSound
		{
			get
			{
				if (_speedOfSound == null)
				{
					_speedOfSound = (CFloat) CR2WTypeManager.Create("Float", "speedOfSound", cr2w, this);
				}
				return _speedOfSound;
			}
			set
			{
				if (_speedOfSound == value)
				{
					return;
				}
				_speedOfSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wideInteriorLimit")] 
		public CFloat WideInteriorLimit
		{
			get
			{
				if (_wideInteriorLimit == null)
				{
					_wideInteriorLimit = (CFloat) CR2WTypeManager.Create("Float", "wideInteriorLimit", cr2w, this);
				}
				return _wideInteriorLimit;
			}
			set
			{
				if (_wideInteriorLimit == value)
				{
					return;
				}
				_wideInteriorLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("enclosedCeilingDistance")] 
		public CFloat EnclosedCeilingDistance
		{
			get
			{
				if (_enclosedCeilingDistance == null)
				{
					_enclosedCeilingDistance = (CFloat) CR2WTypeManager.Create("Float", "enclosedCeilingDistance", cr2w, this);
				}
				return _enclosedCeilingDistance;
			}
			set
			{
				if (_enclosedCeilingDistance == value)
				{
					return;
				}
				_enclosedCeilingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("urbanNarrowDistance")] 
		public CFloat UrbanNarrowDistance
		{
			get
			{
				if (_urbanNarrowDistance == null)
				{
					_urbanNarrowDistance = (CFloat) CR2WTypeManager.Create("Float", "urbanNarrowDistance", cr2w, this);
				}
				return _urbanNarrowDistance;
			}
			set
			{
				if (_urbanNarrowDistance == value)
				{
					return;
				}
				_urbanNarrowDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("urbanStreetDistance")] 
		public CFloat UrbanStreetDistance
		{
			get
			{
				if (_urbanStreetDistance == null)
				{
					_urbanStreetDistance = (CFloat) CR2WTypeManager.Create("Float", "urbanStreetDistance", cr2w, this);
				}
				return _urbanStreetDistance;
			}
			set
			{
				if (_urbanStreetDistance == value)
				{
					return;
				}
				_urbanStreetDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("exteriorWideAltitude")] 
		public CFloat ExteriorWideAltitude
		{
			get
			{
				if (_exteriorWideAltitude == null)
				{
					_exteriorWideAltitude = (CFloat) CR2WTypeManager.Create("Float", "exteriorWideAltitude", cr2w, this);
				}
				return _exteriorWideAltitude;
			}
			set
			{
				if (_exteriorWideAltitude == value)
				{
					return;
				}
				_exteriorWideAltitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("elevatedOpenDistance")] 
		public CFloat ElevatedOpenDistance
		{
			get
			{
				if (_elevatedOpenDistance == null)
				{
					_elevatedOpenDistance = (CFloat) CR2WTypeManager.Create("Float", "elevatedOpenDistance", cr2w, this);
				}
				return _elevatedOpenDistance;
			}
			set
			{
				if (_elevatedOpenDistance == value)
				{
					return;
				}
				_elevatedOpenDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ambExteriorCeilingMinDistance")] 
		public CFloat AmbExteriorCeilingMinDistance
		{
			get
			{
				if (_ambExteriorCeilingMinDistance == null)
				{
					_ambExteriorCeilingMinDistance = (CFloat) CR2WTypeManager.Create("Float", "ambExteriorCeilingMinDistance", cr2w, this);
				}
				return _ambExteriorCeilingMinDistance;
			}
			set
			{
				if (_ambExteriorCeilingMinDistance == value)
				{
					return;
				}
				_ambExteriorCeilingMinDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ambExteriorCeilingMaxDistance")] 
		public CFloat AmbExteriorCeilingMaxDistance
		{
			get
			{
				if (_ambExteriorCeilingMaxDistance == null)
				{
					_ambExteriorCeilingMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "ambExteriorCeilingMaxDistance", cr2w, this);
				}
				return _ambExteriorCeilingMaxDistance;
			}
			set
			{
				if (_ambExteriorCeilingMaxDistance == value)
				{
					return;
				}
				_ambExteriorCeilingMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("badlandsWideRelativeAltitude")] 
		public CFloat BadlandsWideRelativeAltitude
		{
			get
			{
				if (_badlandsWideRelativeAltitude == null)
				{
					_badlandsWideRelativeAltitude = (CFloat) CR2WTypeManager.Create("Float", "badlandsWideRelativeAltitude", cr2w, this);
				}
				return _badlandsWideRelativeAltitude;
			}
			set
			{
				if (_badlandsWideRelativeAltitude == value)
				{
					return;
				}
				_badlandsWideRelativeAltitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("repositioningStandardZoomFactor")] 
		public CFloat RepositioningStandardZoomFactor
		{
			get
			{
				if (_repositioningStandardZoomFactor == null)
				{
					_repositioningStandardZoomFactor = (CFloat) CR2WTypeManager.Create("Float", "repositioningStandardZoomFactor", cr2w, this);
				}
				return _repositioningStandardZoomFactor;
			}
			set
			{
				if (_repositioningStandardZoomFactor == value)
				{
					return;
				}
				_repositioningStandardZoomFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("repositioningScanningZoomFactor")] 
		public CFloat RepositioningScanningZoomFactor
		{
			get
			{
				if (_repositioningScanningZoomFactor == null)
				{
					_repositioningScanningZoomFactor = (CFloat) CR2WTypeManager.Create("Float", "repositioningScanningZoomFactor", cr2w, this);
				}
				return _repositioningScanningZoomFactor;
			}
			set
			{
				if (_repositioningScanningZoomFactor == value)
				{
					return;
				}
				_repositioningScanningZoomFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("repositioningVoStandardZoomFactor")] 
		public CFloat RepositioningVoStandardZoomFactor
		{
			get
			{
				if (_repositioningVoStandardZoomFactor == null)
				{
					_repositioningVoStandardZoomFactor = (CFloat) CR2WTypeManager.Create("Float", "repositioningVoStandardZoomFactor", cr2w, this);
				}
				return _repositioningVoStandardZoomFactor;
			}
			set
			{
				if (_repositioningVoStandardZoomFactor == value)
				{
					return;
				}
				_repositioningVoStandardZoomFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("repositioningVoScanningZoomFactor")] 
		public CFloat RepositioningVoScanningZoomFactor
		{
			get
			{
				if (_repositioningVoScanningZoomFactor == null)
				{
					_repositioningVoScanningZoomFactor = (CFloat) CR2WTypeManager.Create("Float", "repositioningVoScanningZoomFactor", cr2w, this);
				}
				return _repositioningVoScanningZoomFactor;
			}
			set
			{
				if (_repositioningVoScanningZoomFactor == value)
				{
					return;
				}
				_repositioningVoScanningZoomFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("groupingExcludedVisualTags")] 
		public CArray<CName> GroupingExcludedVisualTags
		{
			get
			{
				if (_groupingExcludedVisualTags == null)
				{
					_groupingExcludedVisualTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "groupingExcludedVisualTags", cr2w, this);
				}
				return _groupingExcludedVisualTags;
			}
			set
			{
				if (_groupingExcludedVisualTags == value)
				{
					return;
				}
				_groupingExcludedVisualTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("windowEventName")] 
		public CName WindowEventName
		{
			get
			{
				if (_windowEventName == null)
				{
					_windowEventName = (CName) CR2WTypeManager.Create("CName", "windowEventName", cr2w, this);
				}
				return _windowEventName;
			}
			set
			{
				if (_windowEventName == value)
				{
					return;
				}
				_windowEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("maxWindowOffset")] 
		public CFloat MaxWindowOffset
		{
			get
			{
				if (_maxWindowOffset == null)
				{
					_maxWindowOffset = (CFloat) CR2WTypeManager.Create("Float", "maxWindowOffset", cr2w, this);
				}
				return _maxWindowOffset;
			}
			set
			{
				if (_maxWindowOffset == value)
				{
					return;
				}
				_maxWindowOffset = value;
				PropertySet(this);
			}
		}

		public audioAcousticConstantsPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
