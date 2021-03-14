using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureSlot : CVariable
	{
		private raRef<CBitmapTexture> _texture;
		private CArray<inkTextureAtlasMapper> _parts;
		private CArray<inkTextureAtlasSlice> _slices;

		[Ordinal(0)] 
		[RED("texture")] 
		public raRef<CBitmapTexture> Texture
		{
			get
			{
				if (_texture == null)
				{
					_texture = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "texture", cr2w, this);
				}
				return _texture;
			}
			set
			{
				if (_texture == value)
				{
					return;
				}
				_texture = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get
			{
				if (_parts == null)
				{
					_parts = (CArray<inkTextureAtlasMapper>) CR2WTypeManager.Create("array:inkTextureAtlasMapper", "parts", cr2w, this);
				}
				return _parts;
			}
			set
			{
				if (_parts == value)
				{
					return;
				}
				_parts = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slices")] 
		public CArray<inkTextureAtlasSlice> Slices
		{
			get
			{
				if (_slices == null)
				{
					_slices = (CArray<inkTextureAtlasSlice>) CR2WTypeManager.Create("array:inkTextureAtlasSlice", "slices", cr2w, this);
				}
				return _slices;
			}
			set
			{
				if (_slices == value)
				{
					return;
				}
				_slices = value;
				PropertySet(this);
			}
		}

		public inkTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
