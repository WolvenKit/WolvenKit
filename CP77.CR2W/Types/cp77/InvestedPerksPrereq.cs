using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InvestedPerksPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)] [RED("proficiency")] public CEnum<gamedataProficiencyType> Proficiency { get; set; }

		public InvestedPerksPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
