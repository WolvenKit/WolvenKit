using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Layer : CVariable
	{
		private CFloat _matTile;
		private CFloat _mbTile;
		private rRef<CBitmapTexture> _microblend;
		private CFloat _microblendContrast;
		private CFloat _microblendNormalStrength;
		private CFloat _microblendOffsetU;
		private CFloat _microblendOffsetV;
		private CFloat _opacity;
		private CFloat _offsetU;
		private CFloat _offsetV;
		private rRef<Multilayer_LayerTemplate> _material;
		private CName _colorScale;
		private CName _normalStrength;
		private CName _roughLevelsIn;
		private CName _roughLevelsOut;
		private CName _metalLevelsIn;
		private CName _metalLevelsOut;
		private CName _overrides;

		[Ordinal(0)] 
		[RED("matTile")] 
		public CFloat MatTile
		{
			get
			{
				if (_matTile == null)
				{
					_matTile = (CFloat) CR2WTypeManager.Create("Float", "matTile", cr2w, this);
				}
				return _matTile;
			}
			set
			{
				if (_matTile == value)
				{
					return;
				}
				_matTile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mbTile")] 
		public CFloat MbTile
		{
			get
			{
				if (_mbTile == null)
				{
					_mbTile = (CFloat) CR2WTypeManager.Create("Float", "mbTile", cr2w, this);
				}
				return _mbTile;
			}
			set
			{
				if (_mbTile == value)
				{
					return;
				}
				_mbTile = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("microblend")] 
		public rRef<CBitmapTexture> Microblend
		{
			get
			{
				if (_microblend == null)
				{
					_microblend = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "microblend", cr2w, this);
				}
				return _microblend;
			}
			set
			{
				if (_microblend == value)
				{
					return;
				}
				_microblend = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("microblendContrast")] 
		public CFloat MicroblendContrast
		{
			get
			{
				if (_microblendContrast == null)
				{
					_microblendContrast = (CFloat) CR2WTypeManager.Create("Float", "microblendContrast", cr2w, this);
				}
				return _microblendContrast;
			}
			set
			{
				if (_microblendContrast == value)
				{
					return;
				}
				_microblendContrast = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("microblendNormalStrength")] 
		public CFloat MicroblendNormalStrength
		{
			get
			{
				if (_microblendNormalStrength == null)
				{
					_microblendNormalStrength = (CFloat) CR2WTypeManager.Create("Float", "microblendNormalStrength", cr2w, this);
				}
				return _microblendNormalStrength;
			}
			set
			{
				if (_microblendNormalStrength == value)
				{
					return;
				}
				_microblendNormalStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("microblendOffsetU")] 
		public CFloat MicroblendOffsetU
		{
			get
			{
				if (_microblendOffsetU == null)
				{
					_microblendOffsetU = (CFloat) CR2WTypeManager.Create("Float", "microblendOffsetU", cr2w, this);
				}
				return _microblendOffsetU;
			}
			set
			{
				if (_microblendOffsetU == value)
				{
					return;
				}
				_microblendOffsetU = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("microblendOffsetV")] 
		public CFloat MicroblendOffsetV
		{
			get
			{
				if (_microblendOffsetV == null)
				{
					_microblendOffsetV = (CFloat) CR2WTypeManager.Create("Float", "microblendOffsetV", cr2w, this);
				}
				return _microblendOffsetV;
			}
			set
			{
				if (_microblendOffsetV == value)
				{
					return;
				}
				_microblendOffsetV = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get
			{
				if (_opacity == null)
				{
					_opacity = (CFloat) CR2WTypeManager.Create("Float", "opacity", cr2w, this);
				}
				return _opacity;
			}
			set
			{
				if (_opacity == value)
				{
					return;
				}
				_opacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("offsetU")] 
		public CFloat OffsetU
		{
			get
			{
				if (_offsetU == null)
				{
					_offsetU = (CFloat) CR2WTypeManager.Create("Float", "offsetU", cr2w, this);
				}
				return _offsetU;
			}
			set
			{
				if (_offsetU == value)
				{
					return;
				}
				_offsetU = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("offsetV")] 
		public CFloat OffsetV
		{
			get
			{
				if (_offsetV == null)
				{
					_offsetV = (CFloat) CR2WTypeManager.Create("Float", "offsetV", cr2w, this);
				}
				return _offsetV;
			}
			set
			{
				if (_offsetV == value)
				{
					return;
				}
				_offsetV = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("material")] 
		public rRef<Multilayer_LayerTemplate> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (rRef<Multilayer_LayerTemplate>) CR2WTypeManager.Create("rRef:Multilayer_LayerTemplate", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("colorScale")] 
		public CName ColorScale
		{
			get
			{
				if (_colorScale == null)
				{
					_colorScale = (CName) CR2WTypeManager.Create("CName", "colorScale", cr2w, this);
				}
				return _colorScale;
			}
			set
			{
				if (_colorScale == value)
				{
					return;
				}
				_colorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("normalStrength")] 
		public CName NormalStrength
		{
			get
			{
				if (_normalStrength == null)
				{
					_normalStrength = (CName) CR2WTypeManager.Create("CName", "normalStrength", cr2w, this);
				}
				return _normalStrength;
			}
			set
			{
				if (_normalStrength == value)
				{
					return;
				}
				_normalStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("roughLevelsIn")] 
		public CName RoughLevelsIn
		{
			get
			{
				if (_roughLevelsIn == null)
				{
					_roughLevelsIn = (CName) CR2WTypeManager.Create("CName", "roughLevelsIn", cr2w, this);
				}
				return _roughLevelsIn;
			}
			set
			{
				if (_roughLevelsIn == value)
				{
					return;
				}
				_roughLevelsIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("roughLevelsOut")] 
		public CName RoughLevelsOut
		{
			get
			{
				if (_roughLevelsOut == null)
				{
					_roughLevelsOut = (CName) CR2WTypeManager.Create("CName", "roughLevelsOut", cr2w, this);
				}
				return _roughLevelsOut;
			}
			set
			{
				if (_roughLevelsOut == value)
				{
					return;
				}
				_roughLevelsOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("metalLevelsIn")] 
		public CName MetalLevelsIn
		{
			get
			{
				if (_metalLevelsIn == null)
				{
					_metalLevelsIn = (CName) CR2WTypeManager.Create("CName", "metalLevelsIn", cr2w, this);
				}
				return _metalLevelsIn;
			}
			set
			{
				if (_metalLevelsIn == value)
				{
					return;
				}
				_metalLevelsIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("metalLevelsOut")] 
		public CName MetalLevelsOut
		{
			get
			{
				if (_metalLevelsOut == null)
				{
					_metalLevelsOut = (CName) CR2WTypeManager.Create("CName", "metalLevelsOut", cr2w, this);
				}
				return _metalLevelsOut;
			}
			set
			{
				if (_metalLevelsOut == value)
				{
					return;
				}
				_metalLevelsOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("overrides")] 
		public CName Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CName) CR2WTypeManager.Create("CName", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public Multilayer_Layer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
