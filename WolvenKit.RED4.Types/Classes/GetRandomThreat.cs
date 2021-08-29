using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetRandomThreat : AIRandomTasks
	{
		private CHandle<AIArgumentMapping> _outThreatArgument;

		[Ordinal(0)] 
		[RED("outThreatArgument")] 
		public CHandle<AIArgumentMapping> OutThreatArgument
		{
			get => GetProperty(ref _outThreatArgument);
			set => SetProperty(ref _outThreatArgument, value);
		}
	}
}
