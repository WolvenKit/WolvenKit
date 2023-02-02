
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIWeaponLockedOnTargetCond_Record
	{
		[RED("weaponSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WeaponSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
