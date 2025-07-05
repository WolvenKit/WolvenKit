using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterCube : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("texture")] 
		public CResourceReference<ITexture> Texture
		{
			get => GetPropertyValue<CResourceReference<ITexture>>();
			set => SetPropertyValue<CResourceReference<ITexture>>(value);
		}

		public CMaterialParameterCube()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
