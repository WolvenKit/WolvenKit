using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectManagerComponent : AIMandatoryComponents
	{
		[Ordinal(5)] 
		[RED("weaponDropedInWounded")] 
		public CBool WeaponDropedInWounded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StatusEffectManagerComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
