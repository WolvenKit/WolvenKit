using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGenericGameplayEventOccurredASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] 
		[RED("gameplayEvent")] 
		public CName GameplayEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
