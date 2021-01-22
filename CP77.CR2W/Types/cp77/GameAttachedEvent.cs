using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameAttachedEvent : redEvent
	{
		[Ordinal(0)]  [RED("contentScale")] public TweakDBID ContentScale { get; set; }
		[Ordinal(1)]  [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(2)]  [RED("isGameplayRelevant")] public CBool IsGameplayRelevant { get; set; }

		public GameAttachedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
