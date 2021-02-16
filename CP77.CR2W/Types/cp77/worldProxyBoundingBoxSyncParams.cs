using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldProxyBoundingBoxSyncParams : CVariable
	{
		[Ordinal(0)] [RED("positiveAxis")] public CEnum<worldProxyBBoxSyncOptions> PositiveAxis { get; set; }
		[Ordinal(1)] [RED("negativeAxis")] public CEnum<worldProxyBBoxSyncOptions> NegativeAxis { get; set; }
		[Ordinal(2)] [RED("pullRange")] public CFloat PullRange { get; set; }
		[Ordinal(3)] [RED("makeStackable")] public CBool MakeStackable { get; set; }
		[Ordinal(4)] [RED("stackOffset")] public Vector3 StackOffset { get; set; }

		public worldProxyBoundingBoxSyncParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
