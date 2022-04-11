using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectManagerComponent : AIMandatoryComponents
	{
		[Ordinal(5)] 
		[RED("weaponDropedInWounded")] 
		public CBool WeaponDropedInWounded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
