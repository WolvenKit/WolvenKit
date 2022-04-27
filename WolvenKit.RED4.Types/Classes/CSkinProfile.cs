using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CSkinProfile : CResource
	{
		[Ordinal(1)] 
		[RED("blurSize")] 
		public CFloat BlurSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("diffuse")] 
		public CColor Diffuse
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("falloff")] 
		public CColor Falloff
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(4)] 
		[RED("roughness0")] 
		public CFloat Roughness0
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("roughness1")] 
		public CFloat Roughness1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("lobeMix")] 
		public CFloat LobeMix
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CSkinProfile()
		{
			BlurSize = 1.200000F;
			Diffuse = new();
			Falloff = new();
			Roughness0 = 0.750000F;
			Roughness1 = 1.250000F;
			LobeMix = 0.800000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
