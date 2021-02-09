using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestAnimationMappinController : gameuiQuestMappinController
	{
		[Ordinal(3)]  [RED("mappin")] public wCHandle<gamemappinsQuestMappin> Mappin { get; set; }
		[Ordinal(4)]  [RED("animationRecord")] public CHandle<gamedataUIAnimation_Record> AnimationRecord { get; set; }
		[Ordinal(5)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(6)]  [RED("playing")] public CBool Playing { get; set; }

		public QuestAnimationMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
