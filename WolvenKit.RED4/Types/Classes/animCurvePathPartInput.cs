using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCurvePathPartInput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("curveLengthStart")] 
		public CFloat CurveLengthStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("curveLengthEnd")] 
		public CFloat CurveLengthEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("controllerName")] 
		public CName ControllerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("eventNameStart")] 
		public CName EventNameStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("eventNameEnd")] 
		public CName EventNameEnd
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("startBlendTime")] 
		public CFloat StartBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animCurvePathPartInput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
