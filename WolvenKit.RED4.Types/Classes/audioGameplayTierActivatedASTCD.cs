using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGameplayTierActivatedASTCD : audioAudioStateTransitionConditionData
	{
		private CEnum<audioGameplayTier> _gameplayTier;

		[Ordinal(1)] 
		[RED("gameplayTier")] 
		public CEnum<audioGameplayTier> GameplayTier
		{
			get => GetProperty(ref _gameplayTier);
			set => SetProperty(ref _gameplayTier, value);
		}
	}
}
