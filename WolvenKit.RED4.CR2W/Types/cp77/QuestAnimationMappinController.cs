using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestAnimationMappinController : gameuiQuestMappinController
	{
		[Ordinal(14)] [RED("mappin")] public wCHandle<gamemappinsQuestMappin> Mappin { get; set; }
		[Ordinal(15)] [RED("animationRecord")] public CHandle<gamedataUIAnimation_Record> AnimationRecord { get; set; }
		[Ordinal(16)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(17)] [RED("playing")] public CBool Playing { get; set; }

		public QuestAnimationMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
