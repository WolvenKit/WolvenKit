using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimationSetup : CVariable
	{
		[Ordinal(0)] [RED("cinematics")] public animAnimSetCollection Cinematics { get; set; }
		[Ordinal(1)] [RED("gameplay")] public animAnimSetCollection Gameplay { get; set; }
		[Ordinal(2)] [RED("finalAnimSetCollection")] public animAnimSetCollection FinalAnimSetCollection { get; set; }

		public animAnimationSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
