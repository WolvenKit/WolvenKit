using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSODescRenderTargetSetup : RedBaseClass
	{
		private CStatic<CEnum<GpuWrapApieTextureFormat>> _rtFormats;
		private CEnum<GpuWrapApieTextureFormat> _dsFormat;

		[Ordinal(0)] 
		[RED("rtFormats", 8)] 
		public CStatic<CEnum<GpuWrapApieTextureFormat>> RtFormats
		{
			get => GetProperty(ref _rtFormats);
			set => SetProperty(ref _rtFormats, value);
		}

		[Ordinal(1)] 
		[RED("dsFormat")] 
		public CEnum<GpuWrapApieTextureFormat> DsFormat
		{
			get => GetProperty(ref _dsFormat);
			set => SetProperty(ref _dsFormat, value);
		}
	}
}
