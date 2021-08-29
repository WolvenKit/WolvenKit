using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SkillCheckPrereq : DevelopmentCheckPrereq
	{
		private CEnum<gamedataProficiencyType> _skillToCheck;

		[Ordinal(1)] 
		[RED("skillToCheck")] 
		public CEnum<gamedataProficiencyType> SkillToCheck
		{
			get => GetProperty(ref _skillToCheck);
			set => SetProperty(ref _skillToCheck, value);
		}
	}
}
