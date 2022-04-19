using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowLevelUpNotification_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("levelUpData")] 
		public questLevelUpData LevelUpData
		{
			get => GetPropertyValue<questLevelUpData>();
			set => SetPropertyValue<questLevelUpData>(value);
		}

		public questShowLevelUpNotification_NodeType()
		{
			LevelUpData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
