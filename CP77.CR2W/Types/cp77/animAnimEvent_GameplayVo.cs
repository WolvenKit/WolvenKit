using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_GameplayVo : animAnimEvent
	{
		[Ordinal(0)]  [RED("isQuest")] public CBool IsQuest { get; set; }
		[Ordinal(1)]  [RED("voContext")] public CName VoContext { get; set; }

		public animAnimEvent_GameplayVo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
