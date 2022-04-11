using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SendAIBheaviorReactionStim : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("stimToSend")] 
		public CEnum<gamedataStimType> StimToSend
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}
	}
}
