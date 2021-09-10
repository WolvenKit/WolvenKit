using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PainReactionTask : AIHitReactionTask
	{
		[Ordinal(4)] 
		[RED("weaponOverride")] 
		public CHandle<AnimFeature_WeaponOverride> WeaponOverride
		{
			get => GetPropertyValue<CHandle<AnimFeature_WeaponOverride>>();
			set => SetPropertyValue<CHandle<AnimFeature_WeaponOverride>>(value);
		}
	}
}
