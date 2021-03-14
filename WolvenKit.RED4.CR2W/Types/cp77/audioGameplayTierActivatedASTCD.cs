using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGameplayTierActivatedASTCD : audioAudioStateTransitionConditionData
	{
		private CEnum<audioGameplayTier> _gameplayTier;

		[Ordinal(1)] 
		[RED("gameplayTier")] 
		public CEnum<audioGameplayTier> GameplayTier
		{
			get
			{
				if (_gameplayTier == null)
				{
					_gameplayTier = (CEnum<audioGameplayTier>) CR2WTypeManager.Create("audioGameplayTier", "gameplayTier", cr2w, this);
				}
				return _gameplayTier;
			}
			set
			{
				if (_gameplayTier == value)
				{
					return;
				}
				_gameplayTier = value;
				PropertySet(this);
			}
		}

		public audioGameplayTierActivatedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
