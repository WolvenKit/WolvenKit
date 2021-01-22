using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("debug")] public CBool Debug { get; set; }
		[Ordinal(2)]  [RED("experienceType")] public CEnum<gamedataProficiencyType> ExperienceType { get; set; }

		public AddExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
