using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CSkinProfile : CResource
	{
		private CFloat _blurSize;
		private CColor _diffuse;
		private CColor _falloff;
		private CFloat _roughness0;
		private CFloat _roughness1;
		private CFloat _lobeMix;

		[Ordinal(1)] 
		[RED("blurSize")] 
		public CFloat BlurSize
		{
			get => GetProperty(ref _blurSize);
			set => SetProperty(ref _blurSize, value);
		}

		[Ordinal(2)] 
		[RED("diffuse")] 
		public CColor Diffuse
		{
			get => GetProperty(ref _diffuse);
			set => SetProperty(ref _diffuse, value);
		}

		[Ordinal(3)] 
		[RED("falloff")] 
		public CColor Falloff
		{
			get => GetProperty(ref _falloff);
			set => SetProperty(ref _falloff, value);
		}

		[Ordinal(4)] 
		[RED("roughness0")] 
		public CFloat Roughness0
		{
			get => GetProperty(ref _roughness0);
			set => SetProperty(ref _roughness0, value);
		}

		[Ordinal(5)] 
		[RED("roughness1")] 
		public CFloat Roughness1
		{
			get => GetProperty(ref _roughness1);
			set => SetProperty(ref _roughness1, value);
		}

		[Ordinal(6)] 
		[RED("lobeMix")] 
		public CFloat LobeMix
		{
			get => GetProperty(ref _lobeMix);
			set => SetProperty(ref _lobeMix, value);
		}
	}
}
