using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SendAIBheaviorReactionStim : AIbehaviortaskScript
	{
		private CEnum<gamedataStimType> _stimToSend;

		[Ordinal(0)] 
		[RED("stimToSend")] 
		public CEnum<gamedataStimType> StimToSend
		{
			get => GetProperty(ref _stimToSend);
			set => SetProperty(ref _stimToSend, value);
		}
	}
}
