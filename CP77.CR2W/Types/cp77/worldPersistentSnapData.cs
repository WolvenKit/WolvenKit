using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPersistentSnapData : CVariable
	{
		[Ordinal(0)]  [RED("preserveLength")] public CBool PreserveLength { get; set; }
		[Ordinal(1)]  [RED("reverseTangent")] public CBool ReverseTangent { get; set; }
		[Ordinal(2)]  [RED("snapTangent")] public CBool SnapTangent { get; set; }
		[Ordinal(3)]  [RED("targetObjectPath")] public worldRelativeNodePath TargetObjectPath { get; set; }
		[Ordinal(4)]  [RED("targetSocketName")] public CName TargetSocketName { get; set; }

		public worldPersistentSnapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
