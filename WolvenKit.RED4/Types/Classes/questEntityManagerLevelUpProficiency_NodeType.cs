using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerLevelUpProficiency_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		public questEntityManagerLevelUpProficiency_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
