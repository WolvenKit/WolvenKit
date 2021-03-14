using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmissiveColorSettings : IAreaSettings
	{
		private curveData<HDRColor> _tint;
		private curveData<CFloat> _saturation;
		private curveData<CFloat> _brigtness;
		private curveData<Vector2> _exposure;
		private curveData<Vector2> _cameraLuminance;
		private curveData<CFloat> _evBlend;
		private curveData<CFloat> _exposureIBL;
		private curveData<CFloat> _luminanceIBL;
		private CFloat _curveRampIBL;
		private curveData<CFloat> _exposureScale;

		[Ordinal(2)] 
		[RED("tint")] 
		public curveData<HDRColor> Tint
		{
			get
			{
				if (_tint == null)
				{
					_tint = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "tint", cr2w, this);
				}
				return _tint;
			}
			set
			{
				if (_tint == value)
				{
					return;
				}
				_tint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("saturation")] 
		public curveData<CFloat> Saturation
		{
			get
			{
				if (_saturation == null)
				{
					_saturation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "saturation", cr2w, this);
				}
				return _saturation;
			}
			set
			{
				if (_saturation == value)
				{
					return;
				}
				_saturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("brigtness")] 
		public curveData<CFloat> Brigtness
		{
			get
			{
				if (_brigtness == null)
				{
					_brigtness = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "brigtness", cr2w, this);
				}
				return _brigtness;
			}
			set
			{
				if (_brigtness == value)
				{
					return;
				}
				_brigtness = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("exposure")] 
		public curveData<Vector2> Exposure
		{
			get
			{
				if (_exposure == null)
				{
					_exposure = (curveData<Vector2>) CR2WTypeManager.Create("curveData:Vector2", "exposure", cr2w, this);
				}
				return _exposure;
			}
			set
			{
				if (_exposure == value)
				{
					return;
				}
				_exposure = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("cameraLuminance")] 
		public curveData<Vector2> CameraLuminance
		{
			get
			{
				if (_cameraLuminance == null)
				{
					_cameraLuminance = (curveData<Vector2>) CR2WTypeManager.Create("curveData:Vector2", "cameraLuminance", cr2w, this);
				}
				return _cameraLuminance;
			}
			set
			{
				if (_cameraLuminance == value)
				{
					return;
				}
				_cameraLuminance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("evBlend")] 
		public curveData<CFloat> EvBlend
		{
			get
			{
				if (_evBlend == null)
				{
					_evBlend = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "evBlend", cr2w, this);
				}
				return _evBlend;
			}
			set
			{
				if (_evBlend == value)
				{
					return;
				}
				_evBlend = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("exposureIBL")] 
		public curveData<CFloat> ExposureIBL
		{
			get
			{
				if (_exposureIBL == null)
				{
					_exposureIBL = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureIBL", cr2w, this);
				}
				return _exposureIBL;
			}
			set
			{
				if (_exposureIBL == value)
				{
					return;
				}
				_exposureIBL = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("luminanceIBL")] 
		public curveData<CFloat> LuminanceIBL
		{
			get
			{
				if (_luminanceIBL == null)
				{
					_luminanceIBL = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "luminanceIBL", cr2w, this);
				}
				return _luminanceIBL;
			}
			set
			{
				if (_luminanceIBL == value)
				{
					return;
				}
				_luminanceIBL = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("curveRampIBL")] 
		public CFloat CurveRampIBL
		{
			get
			{
				if (_curveRampIBL == null)
				{
					_curveRampIBL = (CFloat) CR2WTypeManager.Create("Float", "curveRampIBL", cr2w, this);
				}
				return _curveRampIBL;
			}
			set
			{
				if (_curveRampIBL == value)
				{
					return;
				}
				_curveRampIBL = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("exposureScale")] 
		public curveData<CFloat> ExposureScale
		{
			get
			{
				if (_exposureScale == null)
				{
					_exposureScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "exposureScale", cr2w, this);
				}
				return _exposureScale;
			}
			set
			{
				if (_exposureScale == value)
				{
					return;
				}
				_exposureScale = value;
				PropertySet(this);
			}
		}

		public EmissiveColorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
