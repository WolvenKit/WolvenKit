using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GpuWrapApiVertexPackingPackingElement : CVariable
	{
		[Ordinal(0)]  [RED("streamIndex")] public CUInt8 StreamIndex { get; set; }
		[Ordinal(1)]  [RED("streamType")] public CEnum<GpuWrapApiVertexPackingEStreamType> StreamType { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<GpuWrapApiVertexPackingePackingType> Type { get; set; }
		[Ordinal(3)]  [RED("usage")] public CEnum<GpuWrapApiVertexPackingePackingUsage> Usage { get; set; }
		[Ordinal(4)]  [RED("usageIndex")] public CUInt8 UsageIndex { get; set; }

		public GpuWrapApiVertexPackingPackingElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
