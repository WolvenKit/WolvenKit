
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankObstacleSpawnerData_Record
	{
		[RED("levelList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LevelList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("obstacleList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObstacleList
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
