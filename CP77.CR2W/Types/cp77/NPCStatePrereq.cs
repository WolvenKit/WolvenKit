using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCStatePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("isInState")] public CBool IsInState { get; set; }
		[Ordinal(1)]  [RED("previousState")] public CBool PreviousState { get; set; }
		[Ordinal(2)]  [RED("skipWhenApplied")] public CBool SkipWhenApplied { get; set; }

		public NPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
