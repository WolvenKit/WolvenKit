using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MovableQuestTrigger : gameObject
	{
		[Ordinal(31)]  [RED("factName")] public CName FactName { get; set; }
		[Ordinal(32)]  [RED("onlyDetectsPlayer")] public CBool OnlyDetectsPlayer { get; set; }

		public MovableQuestTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
