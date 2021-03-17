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
			get => GetProperty(ref _gameplayTier);
			set => SetProperty(ref _gameplayTier, value);
		}

		public audioGameplayTierActivatedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
