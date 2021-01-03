using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplayMappinController : QuestMappinController
	{
		[Ordinal(0)]  [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }
		[Ordinal(1)]  [RED("isVisibleThroughWalls")] public CBool IsVisibleThroughWalls { get; set; }

		public GameplayMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
