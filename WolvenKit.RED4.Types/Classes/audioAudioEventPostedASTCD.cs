using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioEventPostedASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
