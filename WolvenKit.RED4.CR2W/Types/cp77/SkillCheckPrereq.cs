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
			get
			{
				if (_skillToCheck == null)
				{
					_skillToCheck = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "skillToCheck", cr2w, this);
				}
				return _skillToCheck;
			}
			set
			{
				if (_skillToCheck == value)
				{
					return;
				}
				_skillToCheck = value;
				PropertySet(this);
			}
		}

		public SkillCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
