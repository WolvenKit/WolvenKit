using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCameraComponent : entBaseCameraComponent
	{
		[Ordinal(10)] 
		[RED("animParamFovOverrideWeight")] 
		public CName AnimParamFovOverrideWeight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("animParamFovOverrideValue")] 
		public CName AnimParamFovOverrideValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("animParamZoomOverrideWeight")] 
		public CName AnimParamZoomOverrideWeight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("animParamZoomOverrideValue")] 
		public CName AnimParamZoomOverrideValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("animParamZoomWeaponOverrideWeight")] 
		public CName AnimParamZoomWeaponOverrideWeight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("animParamZoomWeaponOverrideValue")] 
		public CName AnimParamZoomWeaponOverrideValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("animParamdofIntensity")] 
		public CName AnimParamdofIntensity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("animParamdofNearBlur")] 
		public CName AnimParamdofNearBlur
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("animParamdofNearFocus")] 
		public CName AnimParamdofNearFocus
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("animParamdofFarBlur")] 
		public CName AnimParamdofFarBlur
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("animParamdofFarFocus")] 
		public CName AnimParamdofFarFocus
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("fovOverrideWeight")] 
		public CFloat FovOverrideWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("fovOverrideValue")] 
		public CFloat FovOverrideValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("zoomOverrideWeight")] 
		public CFloat ZoomOverrideWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("zoomOverrideValue")] 
		public CFloat ZoomOverrideValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("zoomWeaponOverrideWeight")] 
		public CFloat ZoomWeaponOverrideWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("zoomWeaponOverrideValue")] 
		public CFloat ZoomWeaponOverrideValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("animParamWeaponNearPlaneCM")] 
		public CName AnimParamWeaponNearPlaneCM
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("animParamWeaponFarPlaneCM")] 
		public CName AnimParamWeaponFarPlaneCM
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("animParamWeaponEdgesSharpness")] 
		public CName AnimParamWeaponEdgesSharpness
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("animParamWeaponVignetteIntensity")] 
		public CName AnimParamWeaponVignetteIntensity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("animParamWeaponVignetteRadius")] 
		public CName AnimParamWeaponVignetteRadius
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("animParamWeaponVignetteCircular")] 
		public CName AnimParamWeaponVignetteCircular
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("animParamWeaponBlurIntensity")] 
		public CName AnimParamWeaponBlurIntensity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("weaponPlane")] 
		public SWeaponPlaneParams WeaponPlane
		{
			get => GetPropertyValue<SWeaponPlaneParams>();
			set => SetPropertyValue<SWeaponPlaneParams>(value);
		}

		public gameCameraComponent()
		{
			AnimParamFovOverrideWeight = "fovOverride";
			AnimParamFovOverrideValue = "fovValue";
			AnimParamZoomOverrideWeight = "zoomOverride";
			AnimParamZoomOverrideValue = "zoomValue";
			AnimParamZoomWeaponOverrideWeight = "zoomWeaponOverride";
			AnimParamZoomWeaponOverrideValue = "zoomWeaponValue";
			AnimParamdofIntensity = "dofIntensity";
			AnimParamdofNearBlur = "dofNearBlur";
			AnimParamdofNearFocus = "dofNearFocus";
			AnimParamdofFarBlur = "dofFarBlur";
			AnimParamdofFarFocus = "dofFarFocus";
			AnimParamWeaponNearPlaneCM = "weaponNearPlane";
			AnimParamWeaponFarPlaneCM = "weaponFarPlane";
			AnimParamWeaponEdgesSharpness = "weaponEdgesSharpness";
			AnimParamWeaponVignetteIntensity = "weaponVignetteIntensity";
			AnimParamWeaponVignetteRadius = "weaponVignetteRadius";
			AnimParamWeaponVignetteCircular = "weaponVignetteCircular";
			AnimParamWeaponBlurIntensity = "weaponBlurIntensity";
			WeaponPlane = new SWeaponPlaneParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
