using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDynamicTextureSlot : CVariable
	{
		private raRef<DynamicTexture> _texture;
		private CArray<inkTextureAtlasMapper> _parts;

		[Ordinal(0)] 
		[RED("texture")] 
		public raRef<DynamicTexture> Texture
		{
			get
			{
				if (_texture == null)
				{
					_texture = (raRef<DynamicTexture>) CR2WTypeManager.Create("raRef:DynamicTexture", "texture", cr2w, this);
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

		public inkDynamicTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
