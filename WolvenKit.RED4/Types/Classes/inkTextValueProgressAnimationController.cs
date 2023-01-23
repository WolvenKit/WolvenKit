using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextValueProgressAnimationController : inkTextAnimationController
	{
		[Ordinal(8)] 
		[RED("baseValue")] 
		public CFloat BaseValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("targetValue")] 
		public CFloat TargetValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("numbersAfterDot")] 
		public CInt32 NumbersAfterDot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("stepValue")] 
		public CFloat StepValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("suffix")] 
		public CString Suffix
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkTextValueProgressAnimationController()
		{
			PlayOnInitialize = true;
			UseDefaultAnimation = true;
			EndValue = 1.000000F;
			TargetValue = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
