using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChaosWeaponDamageTypeEffector : ChaosWeaponCustomEffector
	{
		[Ordinal(5)] [RED("damageTypeModGroups")] public CArray<TweakDBID> DamageTypeModGroups { get; set; }

		public ChaosWeaponDamageTypeEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
