using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponSlotHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("weaponAttachmentSlotID")] 
		public TweakDBID WeaponAttachmentSlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public WeaponSlotHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
