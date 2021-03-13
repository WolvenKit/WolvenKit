using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTargetSetup : CVariable
	{
		[Ordinal(0)] [RED("rtFormats", 8)] public CStatic<CEnum<GpuWrapApieTextureFormat>> RtFormats { get; set; }
		[Ordinal(1)] [RED("dsFormat")] public CEnum<GpuWrapApieTextureFormat> DsFormat { get; set; }

		public PSODescRenderTargetSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
