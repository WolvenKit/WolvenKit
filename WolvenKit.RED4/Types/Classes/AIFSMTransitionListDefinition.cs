using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFSMTransitionListDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("firstTransitionIndex")] 
		public CUInt16 FirstTransitionIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("transitionsCount")] 
		public CUInt16 TransitionsCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public AIFSMTransitionListDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
