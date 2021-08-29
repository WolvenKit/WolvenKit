using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimParams : RedBaseClass
	{
		private ReactionOutput _reactionOutput;
		private StimEventData _stimData;

		[Ordinal(0)] 
		[RED("reactionOutput")] 
		public ReactionOutput ReactionOutput
		{
			get => GetProperty(ref _reactionOutput);
			set => SetProperty(ref _reactionOutput, value);
		}

		[Ordinal(1)] 
		[RED("stimData")] 
		public StimEventData StimData
		{
			get => GetProperty(ref _stimData);
			set => SetProperty(ref _stimData, value);
		}
	}
}
