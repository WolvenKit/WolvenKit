using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSODescRenderTargetSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rtFormats", 8)] 
		public CStatic<CEnum<GpuWrapApieTextureFormat>> RtFormats
		{
			get => GetPropertyValue<CStatic<CEnum<GpuWrapApieTextureFormat>>>();
			set => SetPropertyValue<CStatic<CEnum<GpuWrapApieTextureFormat>>>(value);
		}

		[Ordinal(1)] 
		[RED("dsFormat")] 
		public CEnum<GpuWrapApieTextureFormat> DsFormat
		{
			get => GetPropertyValue<CEnum<GpuWrapApieTextureFormat>>();
			set => SetPropertyValue<CEnum<GpuWrapApieTextureFormat>>(value);
		}

		public PSODescRenderTargetSetup()
		{
			RtFormats = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
