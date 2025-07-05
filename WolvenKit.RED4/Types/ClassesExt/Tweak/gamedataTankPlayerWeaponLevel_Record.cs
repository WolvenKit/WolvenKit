
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankPlayerWeaponLevel_Record
	{
		[RED("weaponList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> WeaponList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
