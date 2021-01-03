using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChaosWeaponDamageTypeEffector : ChaosWeaponCustomEffector
	{
		[Ordinal(0)]  [RED("damageTypeModGroups")] public CArray<TweakDBID> DamageTypeModGroups { get; set; }

		public ChaosWeaponDamageTypeEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
