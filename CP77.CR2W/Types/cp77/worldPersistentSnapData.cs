using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPersistentSnapData : CVariable
	{
		[Ordinal(0)]  [RED("targetObjectPath")] public worldRelativeNodePath TargetObjectPath { get; set; }
		[Ordinal(1)]  [RED("targetSocketName")] public CName TargetSocketName { get; set; }
		[Ordinal(2)]  [RED("snapTangent")] public CBool SnapTangent { get; set; }
		[Ordinal(3)]  [RED("reverseTangent")] public CBool ReverseTangent { get; set; }
		[Ordinal(4)]  [RED("preserveLength")] public CBool PreserveLength { get; set; }

		public worldPersistentSnapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
