using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCLocomotionTypePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("locomotionMode")] public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode { get; set; }
		[Ordinal(1)]  [RED("invert")] public CBool Invert { get; set; }

		public NPCLocomotionTypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
