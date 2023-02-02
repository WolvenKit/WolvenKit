using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("experienceType")] 
		public CEnum<gamedataProficiencyType> ExperienceType
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(3)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AddExperience()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
