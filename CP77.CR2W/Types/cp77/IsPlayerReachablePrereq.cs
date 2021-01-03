using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IsPlayerReachablePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("checkRMA")] public CBool CheckRMA { get; set; }
		[Ordinal(1)]  [RED("invert")] public CBool Invert { get; set; }

		public IsPlayerReachablePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
