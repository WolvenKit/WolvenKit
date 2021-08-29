using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PainReactionTask : AIHitReactionTask
	{
		private CHandle<AnimFeature_WeaponOverride> _weaponOverride;

		[Ordinal(4)] 
		[RED("weaponOverride")] 
		public CHandle<AnimFeature_WeaponOverride> WeaponOverride
		{
			get => GetProperty(ref _weaponOverride);
			set => SetProperty(ref _weaponOverride, value);
		}
	}
}
