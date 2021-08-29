using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestSirenEvent : redEvent
	{
		private CBool _lights;
		private CBool _sounds;

		[Ordinal(0)] 
		[RED("lights")] 
		public CBool Lights
		{
			get => GetProperty(ref _lights);
			set => SetProperty(ref _lights, value);
		}

		[Ordinal(1)] 
		[RED("sounds")] 
		public CBool Sounds
		{
			get => GetProperty(ref _sounds);
			set => SetProperty(ref _sounds, value);
		}
	}
}
