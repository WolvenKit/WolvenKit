using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LevelUpUserData : inkGameNotificationData
	{
		private questLevelUpData _data;

		[Ordinal(6)] 
		[RED("data")] 
		public questLevelUpData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
