using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterTexture : CMaterialParameter
	{
		private rRef<ITexture> _texture;

		[Ordinal(2)] 
		[RED("texture")] 
		public rRef<ITexture> Texture
		{
			get
			{
				if (_texture == null)
				{
					_texture = (rRef<ITexture>) CR2WTypeManager.Create("rRef:ITexture", "texture", cr2w, this);
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

		public CMaterialParameterTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
