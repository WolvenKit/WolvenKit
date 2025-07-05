using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterTexture : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("texture")] 
		public CResourceReference<ITexture> Texture
		{
			get => GetPropertyValue<CResourceReference<ITexture>>();
			set => SetPropertyValue<CResourceReference<ITexture>>(value);
		}

		public CMaterialParameterTexture()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
