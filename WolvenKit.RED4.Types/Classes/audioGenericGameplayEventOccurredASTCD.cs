using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGenericGameplayEventOccurredASTCD : audioAudioStateTransitionConditionData
	{
		private CName _gameplayEvent;

		[Ordinal(1)] 
		[RED("gameplayEvent")] 
		public CName GameplayEvent
		{
			get => GetProperty(ref _gameplayEvent);
			set => SetProperty(ref _gameplayEvent, value);
		}
	}
}
