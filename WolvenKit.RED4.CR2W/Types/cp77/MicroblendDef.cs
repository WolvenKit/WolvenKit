using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MicroblendDef : CVariable
	{
		private CName _name;
		private rRef<CBitmapTexture> _texture;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("texture")] 
		public rRef<CBitmapTexture> Texture
		{
			get => GetProperty(ref _texture);
			set => SetProperty(ref _texture, value);
		}

		public MicroblendDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
