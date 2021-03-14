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
			get
			{
				if (_enemyPingStimCount == null)
				{
					_enemyPingStimCount = (CUInt8) CR2WTypeManager.Create("Uint8", "enemyPingStimCount", cr2w, this);
				}
				return _enemyPingStimCount;
			}
			set
			{
				if (_enemyPingStimCount == value)
				{
					return;
				}
				_enemyPingStimCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mixHasDetectedCombat")] 
		public CBool MixHasDetectedCombat
		{
			get
			{
				if (_mixHasDetectedCombat == null)
				{
					_mixHasDetectedCombat = (CBool) CR2WTypeManager.Create("Bool", "mixHasDetectedCombat", cr2w, this);
				}
				return _mixHasDetectedCombat;
			}
			set
			{
				if (_mixHasDetectedCombat == value)
				{
					return;
				}
				_mixHasDetectedCombat = value;
				PropertySet(this);
			}
		}

		public gameGameAudioSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
