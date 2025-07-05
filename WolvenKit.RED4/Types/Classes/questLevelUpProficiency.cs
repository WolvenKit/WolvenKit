using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLevelUpProficiency : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		public questLevelUpProficiency()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
