using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorFindNavigablePointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _destination;
		private CHandle<AIArgumentMapping> _outAdjustedDestination;
		private CHandle<AIArgumentMapping> _outWasAdjusted;

		[Ordinal(1)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		[Ordinal(2)] 
		[RED("outAdjustedDestination")] 
		public CHandle<AIArgumentMapping> OutAdjustedDestination
		{
			get => GetProperty(ref _outAdjustedDestination);
			set => SetProperty(ref _outAdjustedDestination, value);
		}

		[Ordinal(3)] 
		[RED("outWasAdjusted")] 
		public CHandle<AIArgumentMapping> OutWasAdjusted
		{
			get => GetProperty(ref _outWasAdjusted);
			set => SetProperty(ref _outWasAdjusted, value);
		}
	}
}
