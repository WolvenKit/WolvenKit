using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWeaponPlaneParams : CVariable
	{
		private CFloat _weaponNearPlaneCM;
		private CFloat _blurIntensity;

		[Ordinal(0)] 
		[RED("weaponNearPlaneCM")] 
		public CFloat WeaponNearPlaneCM
		{
			get
			{
				if (_weaponNearPlaneCM == null)
				{
					_weaponNearPlaneCM = (CFloat) CR2WTypeManager.Create("Float", "weaponNearPlaneCM", cr2w, this);
				}
				return _weaponNearPlaneCM;
			}
			set
			{
				if (_weaponNearPlaneCM == value)
				{
					return;
				}
				_weaponNearPlaneCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blurIntensity")] 
		public CFloat BlurIntensity
		{
			get
			{
				if (_blurIntensity == null)
				{
					_blurIntensity = (CFloat) CR2WTypeManager.Create("Float", "blurIntensity", cr2w, this);
				}
				return _blurIntensity;
			}
			set
			{
				if (_blurIntensity == value)
				{
					return;
				}
				_blurIntensity = value;
				PropertySet(this);
			}
		}

		public SWeaponPlaneParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
