using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplayMappinController : QuestMappinController
	{
		[Ordinal(22)]  [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }
		[Ordinal(23)]  [RED("isVisibleThroughWalls")] public CBool IsVisibleThroughWalls { get; set; }

		public GameplayMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
