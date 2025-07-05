using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RTXDIAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("diffuseSkyScale")] 
		public CFloat DiffuseSkyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("specularSkyScale")] 
		public CFloat SpecularSkyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RTXDIAreaSettings()
		{
			Enable = true;
			DiffuseSkyScale = 1.000000F;
			SpecularSkyScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
