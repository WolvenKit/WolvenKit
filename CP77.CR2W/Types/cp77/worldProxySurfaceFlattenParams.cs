using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldProxySurfaceFlattenParams : CVariable
	{
		[Ordinal(0)]  [RED("coreAxisRotationOffset")] public CFloat CoreAxisRotationOffset { get; set; }
		[Ordinal(1)]  [RED("flatten")] public CBool Flatten { get; set; }
		[Ordinal(2)]  [RED("groupingStepAngle")] public CEnum<worldProxyNormalAngleStepSize> GroupingStepAngle { get; set; }
		[Ordinal(3)]  [RED("postFlattenReduce")] public CBool PostFlattenReduce { get; set; }
		[Ordinal(4)]  [RED("syncNormalSource")] public CEnum<worldProxySyncNormalSource> SyncNormalSource { get; set; }

		public worldProxySurfaceFlattenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
