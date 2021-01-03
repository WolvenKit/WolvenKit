using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePuppetPS : gameObjectPS
	{
		[Ordinal(0)]  [RED("gender")] public CName Gender { get; set; }
		[Ordinal(1)]  [RED("hasAlternativeName")] public CBool HasAlternativeName { get; set; }
		[Ordinal(2)]  [RED("isCrouch")] public CBool IsCrouch { get; set; }
		[Ordinal(3)]  [RED("wasQuickHacked")] public CBool WasQuickHacked { get; set; }

		public gamePuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
