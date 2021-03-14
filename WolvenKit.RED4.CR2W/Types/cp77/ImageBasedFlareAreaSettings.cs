using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImageBasedFlareAreaSettings : IAreaSettings
	{
		private CFloat _treshold;
		private CFloat _dispersal;
		private CFloat _haloWidth;
		private CFloat _distortion;
		private CFloat _curve;
		private CArrayFixedSize<CColor> _tint;
		private curveData<CFloat> _scale;
		private curveData<CFloat> _saturation;

		[Ordinal(2)] 
		[RED("treshold")] 
		public CFloat Treshold
		{
			get
			{
				if (_treshold == null)
				{
					_treshold = (CFloat) CR2WTypeManager.Create("Float", "treshold", cr2w, this);
				}
				return _treshold;
			}
			set
			{
				if (_treshold == value)
				{
					return;
				}
				_treshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dispersal")] 
		public CFloat Dispersal
		{
			get
			{
				if (_dispersal == null)
				{
					_dispersal = (CFloat) CR2WTypeManager.Create("Float", "dispersal", cr2w, this);
				}
				return _dispersal;
			}
			set
			{
				if (_dispersal == value)
				{
					return;
				}
				_dispersal = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("haloWidth")] 
		public CFloat HaloWidth
		{
			get
			{
				if (_haloWidth == null)
				{
					_haloWidth = (CFloat) CR2WTypeManager.Create("Float", "haloWidth", cr2w, this);
				}
				return _haloWidth;
			}
			set
			{
				if (_haloWidth == value)
				{
					return;
				}
				_haloWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("distortion")] 
		public CFloat Distortion
		{
			get
			{
				if (_distortion == null)
				{
					_distortion = (CFloat) CR2WTypeManager.Create("Float", "distortion", cr2w, this);
				}
				return _distortion;
			}
			set
			{
				if (_distortion == value)
				{
					return;
				}
				_distortion = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("curve")] 
		public CFloat Curve
		{
			get
			{
				if (_curve == null)
				{
					_curve = (CFloat) CR2WTypeManager.Create("Float", "curve", cr2w, this);
				}
				return _curve;
			}
			set
			{
				if (_curve == value)
				{
					return;
				}
				_curve = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tint", 8)] 
		public CArrayFixedSize<CColor> Tint
		{
			get
			{
				if (_tint == null)
				{
					_tint = (CArrayFixedSize<CColor>) CR2WTypeManager.Create("[8]Color", "tint", cr2w, this);
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

		[Ordinal(8)] 
		[RED("scale")] 
		public curveData<CFloat> Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		public ImageBasedFlareAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
