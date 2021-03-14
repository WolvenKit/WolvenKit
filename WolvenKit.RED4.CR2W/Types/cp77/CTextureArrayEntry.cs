using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CTextureArrayEntry : CVariable
	{
		private rRef<CBitmapTexture> _texture;

		[Ordinal(0)] 
		[RED("texture")] 
		public rRef<CBitmapTexture> Texture
		{
			get
			{
				if (_texture == null)
				{
					_texture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "texture", cr2w, this);
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

		public CTextureArrayEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
