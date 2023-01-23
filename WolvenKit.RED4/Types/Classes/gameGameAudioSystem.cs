using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGameAudioSystem : gameIGameAudioSystem
	{
		[Ordinal(0)] 
		[RED("enemyPingStimCount")] 
		public CUInt8 EnemyPingStimCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("mixHasDetectedCombat")] 
		public CBool MixHasDetectedCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameGameAudioSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
