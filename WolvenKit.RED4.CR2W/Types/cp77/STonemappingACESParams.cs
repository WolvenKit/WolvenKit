using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STonemappingACESParams : CVariable
	{
		private CFloat _minStops;
		private CFloat _maxStops;
		private CFloat _midGrayScale;
		private CFloat _surroundGamma;
		private CFloat _toneCurveSaturation;
		private CBool _adjustWhitePoint;
		private CBool _desaturate;
		private CBool _dimSurround;
		private CBool _tonemapLuminance;
		private CBool _applyAfterLUT;

		[Ordinal(0)] 
		[RED("minStops")] 
		public CFloat MinStops
		{
			get
			{
				if (_minStops == null)
				{
					_minStops = (CFloat) CR2WTypeManager.Create("Float", "minStops", cr2w, this);
				}
				return _minStops;
			}
			set
			{
				if (_minStops == value)
				{
					return;
				}
				_minStops = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxStops")] 
		public CFloat MaxStops
		{
			get
			{
				if (_maxStops == null)
				{
					_maxStops = (CFloat) CR2WTypeManager.Create("Float", "maxStops", cr2w, this);
				}
				return _maxStops;
			}
			set
			{
				if (_maxStops == value)
				{
					return;
				}
				_maxStops = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("midGrayScale")] 
		public CFloat MidGrayScale
		{
			get
			{
				if (_midGrayScale == null)
				{
					_midGrayScale = (CFloat) CR2WTypeManager.Create("Float", "midGrayScale", cr2w, this);
				}
				return _midGrayScale;
			}
			set
			{
				if (_midGrayScale == value)
				{
					return;
				}
				_midGrayScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("surroundGamma")] 
		public CFloat SurroundGamma
		{
			get
			{
				if (_surroundGamma == null)
				{
					_surroundGamma = (CFloat) CR2WTypeManager.Create("Float", "surroundGamma", cr2w, this);
				}
				return _surroundGamma;
			}
			set
			{
				if (_surroundGamma == value)
				{
					return;
				}
				_surroundGamma = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("toneCurveSaturation")] 
		public CFloat ToneCurveSaturation
		{
			get
			{
				if (_toneCurveSaturation == null)
				{
					_toneCurveSaturation = (CFloat) CR2WTypeManager.Create("Float", "toneCurveSaturation", cr2w, this);
				}
				return _toneCurveSaturation;
			}
			set
			{
				if (_toneCurveSaturation == value)
				{
					return;
				}
				_toneCurveSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("adjustWhitePoint")] 
		public CBool AdjustWhitePoint
		{
			get
			{
				if (_adjustWhitePoint == null)
				{
					_adjustWhitePoint = (CBool) CR2WTypeManager.Create("Bool", "adjustWhitePoint", cr2w, this);
				}
				return _adjustWhitePoint;
			}
			set
			{
				if (_adjustWhitePoint == value)
				{
					return;
				}
				_adjustWhitePoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("desaturate")] 
		public CBool Desaturate
		{
			get
			{
				if (_desaturate == null)
				{
					_desaturate = (CBool) CR2WTypeManager.Create("Bool", "desaturate", cr2w, this);
				}
				return _desaturate;
			}
			set
			{
				if (_desaturate == value)
				{
					return;
				}
				_desaturate = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dimSurround")] 
		public CBool DimSurround
		{
			get
			{
				if (_dimSurround == null)
				{
					_dimSurround = (CBool) CR2WTypeManager.Create("Bool", "dimSurround", cr2w, this);
				}
				return _dimSurround;
			}
			set
			{
				if (_dimSurround == value)
				{
					return;
				}
				_dimSurround = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("tonemapLuminance")] 
		public CBool TonemapLuminance
		{
			get
			{
				if (_tonemapLuminance == null)
				{
					_tonemapLuminance = (CBool) CR2WTypeManager.Create("Bool", "tonemapLuminance", cr2w, this);
				}
				return _tonemapLuminance;
			}
			set
			{
				if (_tonemapLuminance == value)
				{
					return;
				}
				_tonemapLuminance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("applyAfterLUT")] 
		public CBool ApplyAfterLUT
		{
			get
			{
				if (_applyAfterLUT == null)
				{
					_applyAfterLUT = (CBool) CR2WTypeManager.Create("Bool", "applyAfterLUT", cr2w, this);
				}
				return _applyAfterLUT;
			}
			set
			{
				if (_applyAfterLUT == value)
				{
					return;
				}
				_applyAfterLUT = value;
				PropertySet(this);
			}
		}

		public STonemappingACESParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
