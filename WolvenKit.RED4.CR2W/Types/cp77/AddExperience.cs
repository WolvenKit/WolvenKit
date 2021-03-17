using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddExperience : gamePlayerScriptableSystemRequest
	{
		private CInt32 _amount;
		private CEnum<gamedataProficiencyType> _experienceType;
		private CBool _debug;

		[Ordinal(1)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(2)] 
		[RED("experienceType")] 
		public CEnum<gamedataProficiencyType> ExperienceType
		{
			get => GetProperty(ref _experienceType);
			set => SetProperty(ref _experienceType, value);
		}

		[Ordinal(3)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetProperty(ref _debug);
			set => SetProperty(ref _debug, value);
		}

		public AddExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
