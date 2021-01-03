using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBasePS : gameObjectPS
	{
		[Ordinal(0)]  [RED("isDisabled")] public CBool IsDisabled { get; set; }
		[Ordinal(1)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(2)]  [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }

		public gameLootContainerBasePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
