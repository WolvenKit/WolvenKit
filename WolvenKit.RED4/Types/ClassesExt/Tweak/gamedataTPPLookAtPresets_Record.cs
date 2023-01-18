
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTPPLookAtPresets_Record
	{
		[RED("noWeaponPresets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> NoWeaponPresets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("reloadPresets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ReloadPresets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("weaponReadyPresets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> WeaponReadyPresets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("weaponSafePresets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> WeaponSafePresets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
