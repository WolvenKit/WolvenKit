using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponBlur : animAnimFeature
	{
		private CFloat _weaponNearPlane;
		private CFloat _weaponFarPlane;
		private CFloat _weaponEdgesSharpness;
		private CFloat _weaponVignetteIntensity;
		private CFloat _weaponVignetteRadius;
		private CFloat _weaponVignetteCircular;
		private CFloat _weaponBlurIntensity;
		private CFloat _weaponNearPlane_aim;
		private CFloat _weaponFarPlane_aim;
		private CFloat _weaponEdgesSharpness_aim;
		private CFloat _weaponVignetteIntensity_aim;
		private CFloat _weaponVignetteRadius_aim;
		private CFloat _weaponVignetteCircular_aim;
		private CFloat _weaponBlurIntensity_aim;

		[Ordinal(0)] 
		[RED("weaponNearPlane")] 
		public CFloat WeaponNearPlane
		{
			get
			{
				if (_weaponNearPlane == null)
				{
					_weaponNearPlane = (CFloat) CR2WTypeManager.Create("Float", "weaponNearPlane", cr2w, this);
				}
				return _weaponNearPlane;
			}
			set
			{
				if (_weaponNearPlane == value)
				{
					return;
				}
				_weaponNearPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weaponFarPlane")] 
		public CFloat WeaponFarPlane
		{
			get
			{
				if (_weaponFarPlane == null)
				{
					_weaponFarPlane = (CFloat) CR2WTypeManager.Create("Float", "weaponFarPlane", cr2w, this);
				}
				return _weaponFarPlane;
			}
			set
			{
				if (_weaponFarPlane == value)
				{
					return;
				}
				_weaponFarPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weaponEdgesSharpness")] 
		public CFloat WeaponEdgesSharpness
		{
			get
			{
				if (_weaponEdgesSharpness == null)
				{
					_weaponEdgesSharpness = (CFloat) CR2WTypeManager.Create("Float", "weaponEdgesSharpness", cr2w, this);
				}
				return _weaponEdgesSharpness;
			}
			set
			{
				if (_weaponEdgesSharpness == value)
				{
					return;
				}
				_weaponEdgesSharpness = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weaponVignetteIntensity")] 
		public CFloat WeaponVignetteIntensity
		{
			get
			{
				if (_weaponVignetteIntensity == null)
				{
					_weaponVignetteIntensity = (CFloat) CR2WTypeManager.Create("Float", "weaponVignetteIntensity", cr2w, this);
				}
				return _weaponVignetteIntensity;
			}
			set
			{
				if (_weaponVignetteIntensity == value)
				{
					return;
				}
				_weaponVignetteIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weaponVignetteRadius")] 
		public CFloat WeaponVignetteRadius
		{
			get
			{
				if (_weaponVignetteRadius == null)
				{
					_weaponVignetteRadius = (CFloat) CR2WTypeManager.Create("Float", "weaponVignetteRadius", cr2w, this);
				}
				return _weaponVignetteRadius;
			}
			set
			{
				if (_weaponVignetteRadius == value)
				{
					return;
				}
				_weaponVignetteRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("weaponVignetteCircular")] 
		public CFloat WeaponVignetteCircular
		{
			get
			{
				if (_weaponVignetteCircular == null)
				{
					_weaponVignetteCircular = (CFloat) CR2WTypeManager.Create("Float", "weaponVignetteCircular", cr2w, this);
				}
				return _weaponVignetteCircular;
			}
			set
			{
				if (_weaponVignetteCircular == value)
				{
					return;
				}
				_weaponVignetteCircular = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("weaponBlurIntensity")] 
		public CFloat WeaponBlurIntensity
		{
			get
			{
				if (_weaponBlurIntensity == null)
				{
					_weaponBlurIntensity = (CFloat) CR2WTypeManager.Create("Float", "weaponBlurIntensity", cr2w, this);
				}
				return _weaponBlurIntensity;
			}
			set
			{
				if (_weaponBlurIntensity == value)
				{
					return;
				}
				_weaponBlurIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("weaponNearPlane_aim")] 
		public CFloat WeaponNearPlane_aim
		{
			get
			{
				if (_weaponNearPlane_aim == null)
				{
					_weaponNearPlane_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponNearPlane_aim", cr2w, this);
				}
				return _weaponNearPlane_aim;
			}
			set
			{
				if (_weaponNearPlane_aim == value)
				{
					return;
				}
				_weaponNearPlane_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("weaponFarPlane_aim")] 
		public CFloat WeaponFarPlane_aim
		{
			get
			{
				if (_weaponFarPlane_aim == null)
				{
					_weaponFarPlane_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponFarPlane_aim", cr2w, this);
				}
				return _weaponFarPlane_aim;
			}
			set
			{
				if (_weaponFarPlane_aim == value)
				{
					return;
				}
				_weaponFarPlane_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("weaponEdgesSharpness_aim")] 
		public CFloat WeaponEdgesSharpness_aim
		{
			get
			{
				if (_weaponEdgesSharpness_aim == null)
				{
					_weaponEdgesSharpness_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponEdgesSharpness_aim", cr2w, this);
				}
				return _weaponEdgesSharpness_aim;
			}
			set
			{
				if (_weaponEdgesSharpness_aim == value)
				{
					return;
				}
				_weaponEdgesSharpness_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("weaponVignetteIntensity_aim")] 
		public CFloat WeaponVignetteIntensity_aim
		{
			get
			{
				if (_weaponVignetteIntensity_aim == null)
				{
					_weaponVignetteIntensity_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponVignetteIntensity_aim", cr2w, this);
				}
				return _weaponVignetteIntensity_aim;
			}
			set
			{
				if (_weaponVignetteIntensity_aim == value)
				{
					return;
				}
				_weaponVignetteIntensity_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("weaponVignetteRadius_aim")] 
		public CFloat WeaponVignetteRadius_aim
		{
			get
			{
				if (_weaponVignetteRadius_aim == null)
				{
					_weaponVignetteRadius_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponVignetteRadius_aim", cr2w, this);
				}
				return _weaponVignetteRadius_aim;
			}
			set
			{
				if (_weaponVignetteRadius_aim == value)
				{
					return;
				}
				_weaponVignetteRadius_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("weaponVignetteCircular_aim")] 
		public CFloat WeaponVignetteCircular_aim
		{
			get
			{
				if (_weaponVignetteCircular_aim == null)
				{
					_weaponVignetteCircular_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponVignetteCircular_aim", cr2w, this);
				}
				return _weaponVignetteCircular_aim;
			}
			set
			{
				if (_weaponVignetteCircular_aim == value)
				{
					return;
				}
				_weaponVignetteCircular_aim = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("weaponBlurIntensity_aim")] 
		public CFloat WeaponBlurIntensity_aim
		{
			get
			{
				if (_weaponBlurIntensity_aim == null)
				{
					_weaponBlurIntensity_aim = (CFloat) CR2WTypeManager.Create("Float", "weaponBlurIntensity_aim", cr2w, this);
				}
				return _weaponBlurIntensity_aim;
			}
			set
			{
				if (_weaponBlurIntensity_aim == value)
				{
					return;
				}
				_weaponBlurIntensity_aim = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WeaponBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
