using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(2)] [RED("experienceType")] public CEnum<gamedataProficiencyType> ExperienceType { get; set; }
		[Ordinal(3)] [RED("debug")] public CBool Debug { get; set; }

		public AddExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
