
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIWeaponLockedOnTargetCond_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
