using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxySurfaceFlattenParams : CVariable
	{
		[Ordinal(0)] [RED("flatten")] public CBool Flatten { get; set; }
		[Ordinal(1)] [RED("groupingStepAngle")] public CEnum<worldProxyNormalAngleStepSize> GroupingStepAngle { get; set; }
		[Ordinal(2)] [RED("syncNormalSource")] public CEnum<worldProxySyncNormalSource> SyncNormalSource { get; set; }
		[Ordinal(3)] [RED("coreAxisRotationOffset")] public CFloat CoreAxisRotationOffset { get; set; }
		[Ordinal(4)] [RED("postFlattenReduce")] public CBool PostFlattenReduce { get; set; }

		public worldProxySurfaceFlattenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
