using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetCameraParamsWithOverridesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("sensitivityMultX")] 
		public CFloat SensitivityMultX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("sensitivityMultY")] 
		public CFloat SensitivityMultY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameSetCameraParamsWithOverridesEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
