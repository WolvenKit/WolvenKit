using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChaosWeaponDamageTypeEffector : ChaosWeaponCustomEffector
	{
		[Ordinal(5)]  [RED("damageTypeModGroups")] public CArray<TweakDBID> DamageTypeModGroups { get; set; }

		public ChaosWeaponDamageTypeEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
