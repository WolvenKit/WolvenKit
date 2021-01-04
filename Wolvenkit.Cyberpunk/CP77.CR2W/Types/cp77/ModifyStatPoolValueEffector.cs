using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolValueEffector : gameEffector
	{
		[Ordinal(0)]  [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(1)]  [RED("statPoolUpdates")] public CArray<wCHandle<gamedataStatPoolUpdate_Record>> StatPoolUpdates { get; set; }
		[Ordinal(2)]  [RED("usePercent")] public CBool UsePercent { get; set; }

		public ModifyStatPoolValueEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
