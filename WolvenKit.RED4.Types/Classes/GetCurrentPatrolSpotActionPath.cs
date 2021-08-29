using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetCurrentPatrolSpotActionPath : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _outPathArgument;

		[Ordinal(0)] 
		[RED("outPathArgument")] 
		public CHandle<AIArgumentMapping> OutPathArgument
		{
			get => GetProperty(ref _outPathArgument);
			set => SetProperty(ref _outPathArgument, value);
		}
	}
}
