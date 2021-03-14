using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _exposureAdaptationSpeedUp;
		private curveData<CFloat> _exposureAdaptationSpeedDown;
		private curveData<CFloat> _exposurePercentageThresholdLow;
		private curveData<CFloat> _exposurePercentageThresholdHigh;
		private curveData<CFloat> _exposureCompensation;
		private curveData<CFloat> _exposureSkyImpact;
		private curveData<CFloat> _exposureMin;
		private curveData<CFloat> _exposureMax;
		private curveData<CFloat> _exposureCenterImportance;
		private CFloat _cameraVelocityFaloff;

		[Ordinal(2)] 
		[RED("exposureAdaptationSpeedUp")] 
		public curveData<CFloat> ExposureAdaptationSpeedUp
		{
			get
			{
				if (_exposureAdaptationSpeedUp == null)
				{
					_exposureAdaptationSpeedUp = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureAdaptationSpeedUp", cr2w, this);
				}
				return _exposureAdaptationSpeedUp;
			}
			set
			{
				if (_exposureAdaptationSpeedUp == value)
				{
					return;
				}
				_exposureAdaptationSpeedUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exposureAdaptationSpeedDown")] 
		public curveData<CFloat> ExposureAdaptationSpeedDown
		{
			get
			{
				if (_exposureAdaptationSpeedDown == null)
				{
					_exposureAdaptationSpeedDown = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureAdaptationSpeedDown", cr2w, this);
				}
				return _exposureAdaptationSpeedDown;
			}
			set
			{
				if (_exposureAdaptationSpeedDown == value)
				{
					return;
				}
				_exposureAdaptationSpeedDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exposurePercentageThresholdLow")] 
		public curveData<CFloat> ExposurePercentageThresholdLow
		{
			get
			{
				if (_exposurePercentageThresholdLow == null)
				{
					_exposurePercentageThresholdLow = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposurePercentageThresholdLow", cr2w, this);
				}
				return _exposurePercentageThresholdLow;
			}
			set
			{
				if (_exposurePercentageThresholdLow == value)
				{
					return;
				}
				_exposurePercentageThresholdLow = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("exposurePercentageThresholdHigh")] 
		public curveData<CFloat> ExposurePercentageThresholdHigh
		{
			get
			{
				if (_exposurePercentageThresholdHigh == null)
				{
					_exposurePercentageThresholdHigh = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposurePercentageThresholdHigh", cr2w, this);
				}
				return _exposurePercentageThresholdHigh;
			}
			set
			{
				if (_exposurePercentageThresholdHigh == value)
				{
					return;
				}
				_exposurePercentageThresholdHigh = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("exposureCompensation")] 
		public curveData<CFloat> ExposureCompensation
		{
			get
			{
				if (_exposureCompensation == null)
				{
					_exposureCompensation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureCompensation", cr2w, this);
				}
				return _exposureCompensation;
			}
			set
			{
				if (_exposureCompensation == value)
				{
					return;
				}
				_exposureCompensation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("exposureSkyImpact")] 
		public curveData<CFloat> ExposureSkyImpact
		{
			get
			{
				if (_exposureSkyImpact == null)
				{
					_exposureSkyImpact = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureSkyImpact", cr2w, this);
				}
				return _exposureSkyImpact;
			}
			set
			{
				if (_exposureSkyImpact == value)
				{
					return;
				}
				_exposureSkyImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("exposureMin")] 
		public curveData<CFloat> ExposureMin
		{
			get
			{
				if (_exposureMin == null)
				{
					_exposureMin = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureMin", cr2w, this);
				}
				return _exposureMin;
			}
			set
			{
				if (_exposureMin == value)
				{
					return;
				}
				_exposureMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("exposureMax")] 
		public curveData<CFloat> ExposureMax
		{
			get
			{
				if (_exposureMax == null)
				{
					_exposureMax = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureMax", cr2w, this);
				}
				return _exposureMax;
			}
			set
			{
				if (_exposureMax == value)
				{
					return;
				}
				_exposureMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("exposureCenterImportance")] 
		public curveData<CFloat> ExposureCenterImportance
		{
			get
			{
				if (_exposureCenterImportance == null)
				{
					_exposureCenterImportance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureCenterImportance", cr2w, this);
				}
				return _exposureCenterImportance;
			}
			set
			{
				if (_exposureCenterImportance == value)
				{
					return;
				}
				_exposureCenterImportance = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("cameraVelocityFaloff")] 
		public CFloat CameraVelocityFaloff
		{
			get
			{
				if (_cameraVelocityFaloff == null)
				{
					_cameraVelocityFaloff = (CFloat) CR2WTypeManager.Create("Float", "cameraVelocityFaloff", cr2w, this);
				}
				return _cameraVelocityFaloff;
			}
			set
			{
				if (_cameraVelocityFaloff == value)
				{
					return;
				}
				_cameraVelocityFaloff = value;
				PropertySet(this);
			}
		}

		public ExposureAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
