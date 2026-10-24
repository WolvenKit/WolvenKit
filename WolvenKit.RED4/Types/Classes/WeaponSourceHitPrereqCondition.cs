using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponSourceHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("weaponRecordID")] 
		public TweakDBID WeaponRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public WeaponSourceHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
