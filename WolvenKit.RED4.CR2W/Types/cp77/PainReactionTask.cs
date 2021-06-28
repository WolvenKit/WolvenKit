using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PainReactionTask : AIHitReactionTask
	{
		private CHandle<AnimFeature_WeaponOverride> _weaponOverride;

		[Ordinal(4)] 
		[RED("weaponOverride")] 
		public CHandle<AnimFeature_WeaponOverride> WeaponOverride
		{
			get => GetProperty(ref _weaponOverride);
			set => SetProperty(ref _weaponOverride, value);
		}

		public PainReactionTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
