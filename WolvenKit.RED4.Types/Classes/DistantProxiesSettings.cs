using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistantProxiesSettings : IAreaSettings
	{
		private CFloat _distantProxiesEmissive;
		private CFloat _distantProxiesEmissiveHeight;
		private CFloat _distantProxiesEmissivePower;
		private CFloat _distantProxiesBboxzBlend;

		[Ordinal(2)] 
		[RED("distantProxiesEmissive")] 
		public CFloat DistantProxiesEmissive
		{
			get => GetProperty(ref _distantProxiesEmissive);
			set => SetProperty(ref _distantProxiesEmissive, value);
		}

		[Ordinal(3)] 
		[RED("distantProxiesEmissiveHeight")] 
		public CFloat DistantProxiesEmissiveHeight
		{
			get => GetProperty(ref _distantProxiesEmissiveHeight);
			set => SetProperty(ref _distantProxiesEmissiveHeight, value);
		}

		[Ordinal(4)] 
		[RED("distantProxiesEmissivePower")] 
		public CFloat DistantProxiesEmissivePower
		{
			get => GetProperty(ref _distantProxiesEmissivePower);
			set => SetProperty(ref _distantProxiesEmissivePower, value);
		}

		[Ordinal(5)] 
		[RED("distantProxiesBboxzBlend")] 
		public CFloat DistantProxiesBboxzBlend
		{
			get => GetProperty(ref _distantProxiesBboxzBlend);
			set => SetProperty(ref _distantProxiesBboxzBlend, value);
		}
	}
}
