using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGameAudioSystem : gameIGameAudioSystem
	{
		private CUInt8 _enemyPingStimCount;
		private CBool _mixHasDetectedCombat;

		[Ordinal(0)] 
		[RED("enemyPingStimCount")] 
		public CUInt8 EnemyPingStimCount
		{
			get => GetProperty(ref _enemyPingStimCount);
			set => SetProperty(ref _enemyPingStimCount, value);
		}

		[Ordinal(1)] 
		[RED("mixHasDetectedCombat")] 
		public CBool MixHasDetectedCombat
		{
			get => GetProperty(ref _mixHasDetectedCombat);
			set => SetProperty(ref _mixHasDetectedCombat, value);
		}
	}
}
