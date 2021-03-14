using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChaosWeaponDamageTypeEffector : ChaosWeaponCustomEffector
	{
		private CArray<TweakDBID> _damageTypeModGroups;

		[Ordinal(5)] 
		[RED("damageTypeModGroups")] 
		public CArray<TweakDBID> DamageTypeModGroups
		{
			get
			{
				if (_damageTypeModGroups == null)
				{
					_damageTypeModGroups = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "damageTypeModGroups", cr2w, this);
				}
				return _damageTypeModGroups;
			}
			set
			{
				if (_damageTypeModGroups == value)
				{
					return;
				}
				_damageTypeModGroups = value;
				PropertySet(this);
			}
		}

		public ChaosWeaponDamageTypeEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
