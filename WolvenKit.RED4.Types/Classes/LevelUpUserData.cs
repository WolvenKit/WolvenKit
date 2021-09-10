using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LevelUpUserData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("data")] 
		public questLevelUpData Data
		{
			get => GetPropertyValue<questLevelUpData>();
			set => SetPropertyValue<questLevelUpData>(value);
		}

		public LevelUpUserData()
		{
			Data = new();
		}
	}
}
