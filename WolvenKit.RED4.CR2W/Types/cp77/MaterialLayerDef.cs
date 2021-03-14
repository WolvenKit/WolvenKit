using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialLayerDef : CVariable
	{
		private CName _name;
		private CUInt32 _size;
		private CArray<CColor> _colorPalette;
		private rRef<CMaterialInstance> _material;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CUInt32) CR2WTypeManager.Create("Uint32", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("colorPalette")] 
		public CArray<CColor> ColorPalette
		{
			get
			{
				if (_colorPalette == null)
				{
					_colorPalette = (CArray<CColor>) CR2WTypeManager.Create("array:Color", "colorPalette", cr2w, this);
				}
				return _colorPalette;
			}
			set
			{
				if (_colorPalette == value)
				{
					return;
				}
				_colorPalette = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("material")] 
		public rRef<CMaterialInstance> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (rRef<CMaterialInstance>) CR2WTypeManager.Create("rRef:CMaterialInstance", "material", cr2w, this);
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

		public MaterialLayerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
