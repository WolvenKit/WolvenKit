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
			get => GetProperty(ref _texture);
			set => SetProperty(ref _texture, value);
		}

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}

		public inkDynamicTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
