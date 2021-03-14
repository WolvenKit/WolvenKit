using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialLayerLibrary : CResource
	{
		private CFloat _uvTiling;
		private CFloat _mbTiling;
		private CFloat _microblendContrast;
		private CUInt32 _paletteColorIndex;
		private CArray<MaterialLayerDef> _layers;
		private CArray<MicroblendDef> _microblends;

		[Ordinal(1)] 
		[RED("uvTiling")] 
		public CFloat UvTiling
		{
			get
			{
				if (_uvTiling == null)
				{
					_uvTiling = (CFloat) CR2WTypeManager.Create("Float", "uvTiling", cr2w, this);
				}
				return _uvTiling;
			}
			set
			{
				if (_uvTiling == value)
				{
					return;
				}
				_uvTiling = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mbTiling")] 
		public CFloat MbTiling
		{
			get
			{
				if (_mbTiling == null)
				{
					_mbTiling = (CFloat) CR2WTypeManager.Create("Float", "mbTiling", cr2w, this);
				}
				return _mbTiling;
			}
			set
			{
				if (_mbTiling == value)
				{
					return;
				}
				_mbTiling = value;
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
		[RED("paletteColorIndex")] 
		public CUInt32 PaletteColorIndex
		{
			get
			{
				if (_paletteColorIndex == null)
				{
					_paletteColorIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "paletteColorIndex", cr2w, this);
				}
				return _paletteColorIndex;
			}
			set
			{
				if (_paletteColorIndex == value)
				{
					return;
				}
				_paletteColorIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("layers")] 
		public CArray<MaterialLayerDef> Layers
		{
			get
			{
				if (_layers == null)
				{
					_layers = (CArray<MaterialLayerDef>) CR2WTypeManager.Create("array:MaterialLayerDef", "layers", cr2w, this);
				}
				return _layers;
			}
			set
			{
				if (_layers == value)
				{
					return;
				}
				_layers = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("microblends")] 
		public CArray<MicroblendDef> Microblends
		{
			get
			{
				if (_microblends == null)
				{
					_microblends = (CArray<MicroblendDef>) CR2WTypeManager.Create("array:MicroblendDef", "microblends", cr2w, this);
				}
				return _microblends;
			}
			set
			{
				if (_microblends == value)
				{
					return;
				}
				_microblends = value;
				PropertySet(this);
			}
		}

		public CMaterialLayerLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
