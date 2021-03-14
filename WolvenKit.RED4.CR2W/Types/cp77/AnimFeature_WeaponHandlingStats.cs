using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponHandlingStats : animAnimFeature
	{
		private CFloat _weaponRecoil;
		private CFloat _weaponSpread;

		[Ordinal(0)] 
		[RED("weaponRecoil")] 
		public CFloat WeaponRecoil
		{
			get
			{
				if (_weaponRecoil == null)
				{
					_weaponRecoil = (CFloat) CR2WTypeManager.Create("Float", "weaponRecoil", cr2w, this);
				}
				return _weaponRecoil;
			}
			set
			{
				if (_weaponRecoil == value)
				{
					return;
				}
				_weaponRecoil = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weaponSpread")] 
		public CFloat WeaponSpread
		{
			get
			{
				if (_weaponSpread == null)
				{
					_weaponSpread = (CFloat) CR2WTypeManager.Create("Float", "weaponSpread", cr2w, this);
				}
				return _weaponSpread;
			}
			set
			{
				if (_weaponSpread == value)
				{
					return;
				}
				_weaponSpread = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WeaponHandlingStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
