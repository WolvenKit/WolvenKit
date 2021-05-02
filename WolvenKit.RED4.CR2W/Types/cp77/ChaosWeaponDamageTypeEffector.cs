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
			get => GetProperty(ref _damageTypeModGroups);
			set => SetProperty(ref _damageTypeModGroups, value);
		}

		public ChaosWeaponDamageTypeEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
