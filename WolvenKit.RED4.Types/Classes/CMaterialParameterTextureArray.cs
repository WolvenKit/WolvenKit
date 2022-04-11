using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterTextureArray : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("texture")] 
		public CResourceReference<ITexture> Texture
		{
			get => GetPropertyValue<CResourceReference<ITexture>>();
			set => SetPropertyValue<CResourceReference<ITexture>>(value);
		}
	}
}
