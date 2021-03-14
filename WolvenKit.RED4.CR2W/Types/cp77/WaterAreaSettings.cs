using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WaterAreaSettings : IAreaSettings
	{
		private CFloat _blurMin;
		private CFloat _blurMax;
		private CFloat _blurExponent;
		private CFloat _depth;
		private CFloat _density;
		private HDRColor _lightAbsorptionColor;
		private HDRColor _lightDecayColor;
		private rRef<CBitmapTexture> _globalWaterMask;

		[Ordinal(2)] 
		[RED("blurMin")] 
		public CFloat BlurMin
		{
			get
			{
				if (_blurMin == null)
				{
					_blurMin = (CFloat) CR2WTypeManager.Create("Float", "blurMin", cr2w, this);
				}
				return _blurMin;
			}
			set
			{
				if (_blurMin == value)
				{
					return;
				}
				_blurMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blurMax")] 
		public CFloat BlurMax
		{
			get
			{
				if (_blurMax == null)
				{
					_blurMax = (CFloat) CR2WTypeManager.Create("Float", "blurMax", cr2w, this);
				}
				return _blurMax;
			}
			set
			{
				if (_blurMax == value)
				{
					return;
				}
				_blurMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blurExponent")] 
		public CFloat BlurExponent
		{
			get
			{
				if (_blurExponent == null)
				{
					_blurExponent = (CFloat) CR2WTypeManager.Create("Float", "blurExponent", cr2w, this);
				}
				return _blurExponent;
			}
			set
			{
				if (_blurExponent == value)
				{
					return;
				}
				_blurExponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get
			{
				if (_depth == null)
				{
					_depth = (CFloat) CR2WTypeManager.Create("Float", "depth", cr2w, this);
				}
				return _depth;
			}
			set
			{
				if (_depth == value)
				{
					return;
				}
				_depth = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CFloat Density
		{
			get
			{
				if (_density == null)
				{
					_density = (CFloat) CR2WTypeManager.Create("Float", "density", cr2w, this);
				}
				return _density;
			}
			set
			{
				if (_density == value)
				{
					return;
				}
				_density = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lightAbsorptionColor")] 
		public HDRColor LightAbsorptionColor
		{
			get
			{
				if (_lightAbsorptionColor == null)
				{
					_lightAbsorptionColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "lightAbsorptionColor", cr2w, this);
				}
				return _lightAbsorptionColor;
			}
			set
			{
				if (_lightAbsorptionColor == value)
				{
					return;
				}
				_lightAbsorptionColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lightDecayColor")] 
		public HDRColor LightDecayColor
		{
			get
			{
				if (_lightDecayColor == null)
				{
					_lightDecayColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "lightDecayColor", cr2w, this);
				}
				return _lightDecayColor;
			}
			set
			{
				if (_lightDecayColor == value)
				{
					return;
				}
				_lightDecayColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("globalWaterMask")] 
		public rRef<CBitmapTexture> GlobalWaterMask
		{
			get
			{
				if (_globalWaterMask == null)
				{
					_globalWaterMask = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "globalWaterMask", cr2w, this);
				}
				return _globalWaterMask;
			}
			set
			{
				if (_globalWaterMask == value)
				{
					return;
				}
				_globalWaterMask = value;
				PropertySet(this);
			}
		}

		public WaterAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
