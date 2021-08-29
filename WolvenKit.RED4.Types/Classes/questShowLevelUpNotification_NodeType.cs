using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowLevelUpNotification_NodeType : questIUIManagerNodeType
	{
		private questLevelUpData _levelUpData;

		[Ordinal(0)] 
		[RED("levelUpData")] 
		public questLevelUpData LevelUpData
		{
			get => GetProperty(ref _levelUpData);
			set => SetProperty(ref _levelUpData, value);
		}
	}
}
