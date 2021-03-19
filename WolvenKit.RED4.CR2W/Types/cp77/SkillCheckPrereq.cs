using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillCheckPrereq : DevelopmentCheckPrereq
	{
		private CEnum<gamedataProficiencyType> _skillToCheck;

		[Ordinal(1)] 
		[RED("skillToCheck")] 
		public CEnum<gamedataProficiencyType> SkillToCheck
		{
			get => GetProperty(ref _skillToCheck);
			set => SetProperty(ref _skillToCheck, value);
		}

		public SkillCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
