
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionReloadWeapon_Record
	{
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WeaponSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
