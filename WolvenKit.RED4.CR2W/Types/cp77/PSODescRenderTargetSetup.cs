using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTargetSetup : CVariable
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

		public PSODescRenderTargetSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
