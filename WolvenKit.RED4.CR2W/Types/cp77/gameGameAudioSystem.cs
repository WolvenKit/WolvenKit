using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGameAudioSystem : gameIGameAudioSystem
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

		public gameGameAudioSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
