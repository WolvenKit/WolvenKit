using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_GameplayVo : animAnimEvent
	{
		[Ordinal(0)]  [RED("voContext")] public CName VoContext { get; set; }
		[Ordinal(1)]  [RED("isQuest")] public CBool IsQuest { get; set; }

		public animAnimEvent_GameplayVo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
