using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAnyStateTransitionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("sourceStateId")] 
		public CUInt8 SourceStateId
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("targetStateId")] 
		public CUInt8 TargetStateId
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAnyStateTransitionEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
