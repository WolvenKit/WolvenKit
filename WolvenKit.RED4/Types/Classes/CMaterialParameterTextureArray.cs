using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterTextureArray : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("texture")] 
		public CResourceReference<ITexture> Texture
		{
			get => GetPropertyValue<CResourceReference<ITexture>>();
			set => SetPropertyValue<CResourceReference<ITexture>>(value);
		}

		public CMaterialParameterTextureArray()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
