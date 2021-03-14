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
			get
			{
				if (_animParamFovOverrideWeight == null)
				{
					_animParamFovOverrideWeight = (CName) CR2WTypeManager.Create("CName", "animParamFovOverrideWeight", cr2w, this);
				}
				return _animParamFovOverrideWeight;
			}
			set
			{
				if (_animParamFovOverrideWeight == value)
				{
					return;
				}
				_animParamFovOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animParamFovOverrideValue")] 
		public CName AnimParamFovOverrideValue
		{
			get
			{
				if (_animParamFovOverrideValue == null)
				{
					_animParamFovOverrideValue = (CName) CR2WTypeManager.Create("CName", "animParamFovOverrideValue", cr2w, this);
				}
				return _animParamFovOverrideValue;
			}
			set
			{
				if (_animParamFovOverrideValue == value)
				{
					return;
				}
				_animParamFovOverrideValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("animParamZoomOverrideWeight")] 
		public CName AnimParamZoomOverrideWeight
		{
			get
			{
				if (_animParamZoomOverrideWeight == null)
				{
					_animParamZoomOverrideWeight = (CName) CR2WTypeManager.Create("CName", "animParamZoomOverrideWeight", cr2w, this);
				}
				return _animParamZoomOverrideWeight;
			}
			set
			{
				if (_animParamZoomOverrideWeight == value)
				{
					return;
				}
				_animParamZoomOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animParamZoomOverrideValue")] 
		public CName AnimParamZoomOverrideValue
		{
			get
			{
				if (_animParamZoomOverrideValue == null)
				{
					_animParamZoomOverrideValue = (CName) CR2WTypeManager.Create("CName", "animParamZoomOverrideValue", cr2w, this);
				}
				return _animParamZoomOverrideValue;
			}
			set
			{
				if (_animParamZoomOverrideValue == value)
				{
					return;
				}
				_animParamZoomOverrideValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animParamZoomWeaponOverrideWeight")] 
		public CName AnimParamZoomWeaponOverrideWeight
		{
			get
			{
				if (_animParamZoomWeaponOverrideWeight == null)
				{
					_animParamZoomWeaponOverrideWeight = (CName) CR2WTypeManager.Create("CName", "animParamZoomWeaponOverrideWeight", cr2w, this);
				}
				return _animParamZoomWeaponOverrideWeight;
			}
			set
			{
				if (_animParamZoomWeaponOverrideWeight == value)
				{
					return;
				}
				_animParamZoomWeaponOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animParamZoomWeaponOverrideValue")] 
		public CName AnimParamZoomWeaponOverrideValue
		{
			get
			{
				if (_animParamZoomWeaponOverrideValue == null)
				{
					_animParamZoomWeaponOverrideValue = (CName) CR2WTypeManager.Create("CName", "animParamZoomWeaponOverrideValue", cr2w, this);
				}
				return _animParamZoomWeaponOverrideValue;
			}
			set
			{
				if (_animParamZoomWeaponOverrideValue == value)
				{
					return;
				}
				_animParamZoomWeaponOverrideValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("animParamdofIntensity")] 
		public CName AnimParamdofIntensity
		{
			get
			{
				if (_animParamdofIntensity == null)
				{
					_animParamdofIntensity = (CName) CR2WTypeManager.Create("CName", "animParamdofIntensity", cr2w, this);
				}
				return _animParamdofIntensity;
			}
			set
			{
				if (_animParamdofIntensity == value)
				{
					return;
				}
				_animParamdofIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animParamdofNearBlur")] 
		public CName AnimParamdofNearBlur
		{
			get
			{
				if (_animParamdofNearBlur == null)
				{
					_animParamdofNearBlur = (CName) CR2WTypeManager.Create("CName", "animParamdofNearBlur", cr2w, this);
				}
				return _animParamdofNearBlur;
			}
			set
			{
				if (_animParamdofNearBlur == value)
				{
					return;
				}
				_animParamdofNearBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animParamdofNearFocus")] 
		public CName AnimParamdofNearFocus
		{
			get
			{
				if (_animParamdofNearFocus == null)
				{
					_animParamdofNearFocus = (CName) CR2WTypeManager.Create("CName", "animParamdofNearFocus", cr2w, this);
				}
				return _animParamdofNearFocus;
			}
			set
			{
				if (_animParamdofNearFocus == value)
				{
					return;
				}
				_animParamdofNearFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animParamdofFarBlur")] 
		public CName AnimParamdofFarBlur
		{
			get
			{
				if (_animParamdofFarBlur == null)
				{
					_animParamdofFarBlur = (CName) CR2WTypeManager.Create("CName", "animParamdofFarBlur", cr2w, this);
				}
				return _animParamdofFarBlur;
			}
			set
			{
				if (_animParamdofFarBlur == value)
				{
					return;
				}
				_animParamdofFarBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animParamdofFarFocus")] 
		public CName AnimParamdofFarFocus
		{
			get
			{
				if (_animParamdofFarFocus == null)
				{
					_animParamdofFarFocus = (CName) CR2WTypeManager.Create("CName", "animParamdofFarFocus", cr2w, this);
				}
				return _animParamdofFarFocus;
			}
			set
			{
				if (_animParamdofFarFocus == value)
				{
					return;
				}
				_animParamdofFarFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("fovOverrideWeight")] 
		public CFloat FovOverrideWeight
		{
			get
			{
				if (_fovOverrideWeight == null)
				{
					_fovOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "fovOverrideWeight", cr2w, this);
				}
				return _fovOverrideWeight;
			}
			set
			{
				if (_fovOverrideWeight == value)
				{
					return;
				}
				_fovOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("fovOverrideValue")] 
		public CFloat FovOverrideValue
		{
			get
			{
				if (_fovOverrideValue == null)
				{
					_fovOverrideValue = (CFloat) CR2WTypeManager.Create("Float", "fovOverrideValue", cr2w, this);
				}
				return _fovOverrideValue;
			}
			set
			{
				if (_fovOverrideValue == value)
				{
					return;
				}
				_fovOverrideValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("zoomOverrideWeight")] 
		public CFloat ZoomOverrideWeight
		{
			get
			{
				if (_zoomOverrideWeight == null)
				{
					_zoomOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "zoomOverrideWeight", cr2w, this);
				}
				return _zoomOverrideWeight;
			}
			set
			{
				if (_zoomOverrideWeight == value)
				{
					return;
				}
				_zoomOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("zoomOverrideValue")] 
		public CFloat ZoomOverrideValue
		{
			get
			{
				if (_zoomOverrideValue == null)
				{
					_zoomOverrideValue = (CFloat) CR2WTypeManager.Create("Float", "zoomOverrideValue", cr2w, this);
				}
				return _zoomOverrideValue;
			}
			set
			{
				if (_zoomOverrideValue == value)
				{
					return;
				}
				_zoomOverrideValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("zoomWeaponOverrideWeight")] 
		public CFloat ZoomWeaponOverrideWeight
		{
			get
			{
				if (_zoomWeaponOverrideWeight == null)
				{
					_zoomWeaponOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "zoomWeaponOverrideWeight", cr2w, this);
				}
				return _zoomWeaponOverrideWeight;
			}
			set
			{
				if (_zoomWeaponOverrideWeight == value)
				{
					return;
				}
				_zoomWeaponOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("zoomWeaponOverrideValue")] 
		public CFloat ZoomWeaponOverrideValue
		{
			get
			{
				if (_zoomWeaponOverrideValue == null)
				{
					_zoomWeaponOverrideValue = (CFloat) CR2WTypeManager.Create("Float", "zoomWeaponOverrideValue", cr2w, this);
				}
				return _zoomWeaponOverrideValue;
			}
			set
			{
				if (_zoomWeaponOverrideValue == value)
				{
					return;
				}
				_zoomWeaponOverrideValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("animParamWeaponNearPlaneCM")] 
		public CName AnimParamWeaponNearPlaneCM
		{
			get
			{
				if (_animParamWeaponNearPlaneCM == null)
				{
					_animParamWeaponNearPlaneCM = (CName) CR2WTypeManager.Create("CName", "animParamWeaponNearPlaneCM", cr2w, this);
				}
				return _animParamWeaponNearPlaneCM;
			}
			set
			{
				if (_animParamWeaponNearPlaneCM == value)
				{
					return;
				}
				_animParamWeaponNearPlaneCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("animParamWeaponFarPlaneCM")] 
		public CName AnimParamWeaponFarPlaneCM
		{
			get
			{
				if (_animParamWeaponFarPlaneCM == null)
				{
					_animParamWeaponFarPlaneCM = (CName) CR2WTypeManager.Create("CName", "animParamWeaponFarPlaneCM", cr2w, this);
				}
				return _animParamWeaponFarPlaneCM;
			}
			set
			{
				if (_animParamWeaponFarPlaneCM == value)
				{
					return;
				}
				_animParamWeaponFarPlaneCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("animParamWeaponEdgesSharpness")] 
		public CName AnimParamWeaponEdgesSharpness
		{
			get
			{
				if (_animParamWeaponEdgesSharpness == null)
				{
					_animParamWeaponEdgesSharpness = (CName) CR2WTypeManager.Create("CName", "animParamWeaponEdgesSharpness", cr2w, this);
				}
				return _animParamWeaponEdgesSharpness;
			}
			set
			{
				if (_animParamWeaponEdgesSharpness == value)
				{
					return;
				}
				_animParamWeaponEdgesSharpness = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("animParamWeaponVignetteIntensity")] 
		public CName AnimParamWeaponVignetteIntensity
		{
			get
			{
				if (_animParamWeaponVignetteIntensity == null)
				{
					_animParamWeaponVignetteIntensity = (CName) CR2WTypeManager.Create("CName", "animParamWeaponVignetteIntensity", cr2w, this);
				}
				return _animParamWeaponVignetteIntensity;
			}
			set
			{
				if (_animParamWeaponVignetteIntensity == value)
				{
					return;
				}
				_animParamWeaponVignetteIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("animParamWeaponVignetteRadius")] 
		public CName AnimParamWeaponVignetteRadius
		{
			get
			{
				if (_animParamWeaponVignetteRadius == null)
				{
					_animParamWeaponVignetteRadius = (CName) CR2WTypeManager.Create("CName", "animParamWeaponVignetteRadius", cr2w, this);
				}
				return _animParamWeaponVignetteRadius;
			}
			set
			{
				if (_animParamWeaponVignetteRadius == value)
				{
					return;
				}
				_animParamWeaponVignetteRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("animParamWeaponVignetteCircular")] 
		public CName AnimParamWeaponVignetteCircular
		{
			get
			{
				if (_animParamWeaponVignetteCircular == null)
				{
					_animParamWeaponVignetteCircular = (CName) CR2WTypeManager.Create("CName", "animParamWeaponVignetteCircular", cr2w, this);
				}
				return _animParamWeaponVignetteCircular;
			}
			set
			{
				if (_animParamWeaponVignetteCircular == value)
				{
					return;
				}
				_animParamWeaponVignetteCircular = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("animParamWeaponBlurIntensity")] 
		public CName AnimParamWeaponBlurIntensity
		{
			get
			{
				if (_animParamWeaponBlurIntensity == null)
				{
					_animParamWeaponBlurIntensity = (CName) CR2WTypeManager.Create("CName", "animParamWeaponBlurIntensity", cr2w, this);
				}
				return _animParamWeaponBlurIntensity;
			}
			set
			{
				if (_animParamWeaponBlurIntensity == value)
				{
					return;
				}
				_animParamWeaponBlurIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("weaponPlane")] 
		public SWeaponPlaneParams WeaponPlane
		{
			get
			{
				if (_weaponPlane == null)
				{
					_weaponPlane = (SWeaponPlaneParams) CR2WTypeManager.Create("SWeaponPlaneParams", "weaponPlane", cr2w, this);
				}
				return _weaponPlane;
			}
			set
			{
				if (_weaponPlane == value)
				{
					return;
				}
				_weaponPlane = value;
				PropertySet(this);
			}
		}

		public gameCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
