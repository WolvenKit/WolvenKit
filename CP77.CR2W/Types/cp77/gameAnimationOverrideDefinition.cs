using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAnimationOverrideDefinition : CVariable
	{
		[Ordinal(0)]  [RED("animset")] public raRef<animAnimSet> Animset { get; set; }
		[Ordinal(1)]  [RED("variables")] public CArray<CName> Variables { get; set; }

		public gameAnimationOverrideDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
