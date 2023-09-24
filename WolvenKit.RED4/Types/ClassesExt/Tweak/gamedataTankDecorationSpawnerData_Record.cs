
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankDecorationSpawnerData_Record
	{
		[RED("levelList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LevelList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("spawnTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
