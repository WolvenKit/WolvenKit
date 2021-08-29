using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFSMTransitionListDefinition : RedBaseClass
	{
		private CUInt16 _firstTransitionIndex;
		private CUInt16 _transitionsCount;

		[Ordinal(0)] 
		[RED("firstTransitionIndex")] 
		public CUInt16 FirstTransitionIndex
		{
			get => GetProperty(ref _firstTransitionIndex);
			set => SetProperty(ref _firstTransitionIndex, value);
		}

		[Ordinal(1)] 
		[RED("transitionsCount")] 
		public CUInt16 TransitionsCount
		{
			get => GetProperty(ref _transitionsCount);
			set => SetProperty(ref _transitionsCount, value);
		}
	}
}
