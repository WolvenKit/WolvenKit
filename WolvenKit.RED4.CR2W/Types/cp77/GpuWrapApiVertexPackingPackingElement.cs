using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GpuWrapApiVertexPackingPackingElement : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<GpuWrapApiVertexPackingePackingType> Type { get; set; }
		[Ordinal(1)] [RED("usage")] public CEnum<GpuWrapApiVertexPackingePackingUsage> Usage { get; set; }
		[Ordinal(2)] [RED("usageIndex")] public CUInt8 UsageIndex { get; set; }
		[Ordinal(3)] [RED("streamIndex")] public CUInt8 StreamIndex { get; set; }
		[Ordinal(4)] [RED("streamType")] public CEnum<GpuWrapApiVertexPackingEStreamType> StreamType { get; set; }

		public GpuWrapApiVertexPackingPackingElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
