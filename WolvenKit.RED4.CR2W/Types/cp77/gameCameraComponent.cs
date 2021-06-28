using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCameraComponent : entBaseCameraComponent
	{
		private CName _animParamFovOverrideWeight;
		private CName _animParamFovOverrideValue;
		private CName _animParamZoomOverrideWeight;
		private CName _animParamZoomOverrideValue;
		private CName _animParamZoomWeaponOverrideWeight;
		private CName _animParamZoomWeaponOverrideValue;
		private CName _animParamdofIntensity;
		private CName _animParamdofNearBlur;
		private CName _animParamdofNearFocus;
		private CName _animParamdofFarBlur;
		private CName _animParamdofFarFocus;
		private CFloat _fovOverrideWeight;
		private CFloat _fovOverrideValue;
		private CFloat _zoomOverrideWeight;
		private CFloat _zoomOverrideValue;
		private CFloat _zoomWeaponOverrideWeight;
		private CFloat _zoomWeaponOverrideValue;
		private CName _animParamWeaponNearPlaneCM;
		private CName _animParamWeaponFarPlaneCM;
		private CName _animParamWeaponEdgesSharpness;
		private CName _animParamWeaponVignetteIntensity;
		private CName _animParamWeaponVignetteRadius;
		private CName _animParamWeaponVignetteCircular;
		private CName _animParamWeaponBlurIntensity;
		private SWeaponPlaneParams _weaponPlane;

		[Ordinal(10)] 
		[RED("animParamFovOverrideWeight")] 
		public CName AnimParamFovOverrideWeight
		{
			get => GetProperty(ref _animParamFovOverrideWeight);
			set => SetProperty(ref _animParamFovOverrideWeight, value);
		}

		[Ordinal(11)] 
		[RED("animParamFovOverrideValue")] 
		public CName AnimParamFovOverrideValue
		{
			get => GetProperty(ref _animParamFovOverrideValue);
			set => SetProperty(ref _animParamFovOverrideValue, value);
		}

		[Ordinal(12)] 
		[RED("animParamZoomOverrideWeight")] 
		public CName AnimParamZoomOverrideWeight
		{
			get => GetProperty(ref _animParamZoomOverrideWeight);
			set => SetProperty(ref _animParamZoomOverrideWeight, value);
		}

		[Ordinal(13)] 
		[RED("animParamZoomOverrideValue")] 
		public CName AnimParamZoomOverrideValue
		{
			get => GetProperty(ref _animParamZoomOverrideValue);
			set => SetProperty(ref _animParamZoomOverrideValue, value);
		}

		[Ordinal(14)] 
		[RED("animParamZoomWeaponOverrideWeight")] 
		public CName AnimParamZoomWeaponOverrideWeight
		{
			get => GetProperty(ref _animParamZoomWeaponOverrideWeight);
			set => SetProperty(ref _animParamZoomWeaponOverrideWeight, value);
		}

		[Ordinal(15)] 
		[RED("animParamZoomWeaponOverrideValue")] 
		public CName AnimParamZoomWeaponOverrideValue
		{
			get => GetProperty(ref _animParamZoomWeaponOverrideValue);
			set => SetProperty(ref _animParamZoomWeaponOverrideValue, value);
		}

		[Ordinal(16)] 
		[RED("animParamdofIntensity")] 
		public CName AnimParamdofIntensity
		{
			get => GetProperty(ref _animParamdofIntensity);
			set => SetProperty(ref _animParamdofIntensity, value);
		}

		[Ordinal(17)] 
		[RED("animParamdofNearBlur")] 
		public CName AnimParamdofNearBlur
		{
			get => GetProperty(ref _animParamdofNearBlur);
			set => SetProperty(ref _animParamdofNearBlur, value);
		}

		[Ordinal(18)] 
		[RED("animParamdofNearFocus")] 
		public CName AnimParamdofNearFocus
		{
			get => GetProperty(ref _animParamdofNearFocus);
			set => SetProperty(ref _animParamdofNearFocus, value);
		}

		[Ordinal(19)] 
		[RED("animParamdofFarBlur")] 
		public CName AnimParamdofFarBlur
		{
			get => GetProperty(ref _animParamdofFarBlur);
			set => SetProperty(ref _animParamdofFarBlur, value);
		}

		[Ordinal(20)] 
		[RED("animParamdofFarFocus")] 
		public CName AnimParamdofFarFocus
		{
			get => GetProperty(ref _animParamdofFarFocus);
			set => SetProperty(ref _animParamdofFarFocus, value);
		}

		[Ordinal(21)] 
		[RED("fovOverrideWeight")] 
		public CFloat FovOverrideWeight
		{
			get => GetProperty(ref _fovOverrideWeight);
			set => SetProperty(ref _fovOverrideWeight, value);
		}

		[Ordinal(22)] 
		[RED("fovOverrideValue")] 
		public CFloat FovOverrideValue
		{
			get => GetProperty(ref _fovOverrideValue);
			set => SetProperty(ref _fovOverrideValue, value);
		}

		[Ordinal(23)] 
		[RED("zoomOverrideWeight")] 
		public CFloat ZoomOverrideWeight
		{
			get => GetProperty(ref _zoomOverrideWeight);
			set => SetProperty(ref _zoomOverrideWeight, value);
		}

		[Ordinal(24)] 
		[RED("zoomOverrideValue")] 
		public CFloat ZoomOverrideValue
		{
			get => GetProperty(ref _zoomOverrideValue);
			set => SetProperty(ref _zoomOverrideValue, value);
		}

		[Ordinal(25)] 
		[RED("zoomWeaponOverrideWeight")] 
		public CFloat ZoomWeaponOverrideWeight
		{
			get => GetProperty(ref _zoomWeaponOverrideWeight);
			set => SetProperty(ref _zoomWeaponOverrideWeight, value);
		}

		[Ordinal(26)] 
		[RED("zoomWeaponOverrideValue")] 
		public CFloat ZoomWeaponOverrideValue
		{
			get => GetProperty(ref _zoomWeaponOverrideValue);
			set => SetProperty(ref _zoomWeaponOverrideValue, value);
		}

		[Ordinal(27)] 
		[RED("animParamWeaponNearPlaneCM")] 
		public CName AnimParamWeaponNearPlaneCM
		{
			get => GetProperty(ref _animParamWeaponNearPlaneCM);
			set => SetProperty(ref _animParamWeaponNearPlaneCM, value);
		}

		[Ordinal(28)] 
		[RED("animParamWeaponFarPlaneCM")] 
		public CName AnimParamWeaponFarPlaneCM
		{
			get => GetProperty(ref _animParamWeaponFarPlaneCM);
			set => SetProperty(ref _animParamWeaponFarPlaneCM, value);
		}

		[Ordinal(29)] 
		[RED("animParamWeaponEdgesSharpness")] 
		public CName AnimParamWeaponEdgesSharpness
		{
			get => GetProperty(ref _animParamWeaponEdgesSharpness);
			set => SetProperty(ref _animParamWeaponEdgesSharpness, value);
		}

		[Ordinal(30)] 
		[RED("animParamWeaponVignetteIntensity")] 
		public CName AnimParamWeaponVignetteIntensity
		{
			get => GetProperty(ref _animParamWeaponVignetteIntensity);
			set => SetProperty(ref _animParamWeaponVignetteIntensity, value);
		}

		[Ordinal(31)] 
		[RED("animParamWeaponVignetteRadius")] 
		public CName AnimParamWeaponVignetteRadius
		{
			get => GetProperty(ref _animParamWeaponVignetteRadius);
			set => SetProperty(ref _animParamWeaponVignetteRadius, value);
		}

		[Ordinal(32)] 
		[RED("animParamWeaponVignetteCircular")] 
		public CName AnimParamWeaponVignetteCircular
		{
			get => GetProperty(ref _animParamWeaponVignetteCircular);
			set => SetProperty(ref _animParamWeaponVignetteCircular, value);
		}

		[Ordinal(33)] 
		[RED("animParamWeaponBlurIntensity")] 
		public CName AnimParamWeaponBlurIntensity
		{
			get => GetProperty(ref _animParamWeaponBlurIntensity);
			set => SetProperty(ref _animParamWeaponBlurIntensity, value);
		}

		[Ordinal(34)] 
		[RED("weaponPlane")] 
		public SWeaponPlaneParams WeaponPlane
		{
			get => GetProperty(ref _weaponPlane);
			set => SetProperty(ref _weaponPlane, value);
		}

		public gameCameraComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
