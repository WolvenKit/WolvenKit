using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTargetSetup : CVariable
	{
		[Ordinal(0)]  [RED("dsFormat")] public CEnum<GpuWrapApieTextureFormat> DsFormat { get; set; }
		[Ordinal(1)]  [RED("rtFormats")] public CStatic<8,GpuWrapApieTextureFormat> RtFormats { get; set; }

		public PSODescRenderTargetSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
