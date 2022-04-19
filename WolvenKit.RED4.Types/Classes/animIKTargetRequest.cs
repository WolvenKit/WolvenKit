using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animIKTargetRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("weightOrientation")] 
		public CFloat WeightOrientation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("transitionIn")] 
		public CFloat TransitionIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("transitionOut")] 
		public CFloat TransitionOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animIKTargetRequest()
		{
			WeightPosition = 1.000000F;
			WeightOrientation = 1.000000F;
			TransitionIn = 0.300000F;
			TransitionOut = 0.300000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
