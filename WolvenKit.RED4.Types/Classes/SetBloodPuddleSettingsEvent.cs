using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBloodPuddleSettingsEvent : redEvent
	{
		private CBool _shouldSpawnBloodPuddle;

		[Ordinal(0)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get => GetProperty(ref _shouldSpawnBloodPuddle);
			set => SetProperty(ref _shouldSpawnBloodPuddle, value);
		}

		public SetBloodPuddleSettingsEvent()
		{
			_shouldSpawnBloodPuddle = true;
		}
	}
}
