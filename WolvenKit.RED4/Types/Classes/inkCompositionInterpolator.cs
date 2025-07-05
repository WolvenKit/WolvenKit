using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCompositionInterpolator : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationMode>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationMode>>(value);
		}

		[Ordinal(2)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationType>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationType>>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkCompositionInterpolator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
