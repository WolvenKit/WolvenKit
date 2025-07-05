
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankProjectileSpawnerData_Record
	{
		[RED("projectileList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ProjectileList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
