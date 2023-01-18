
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUISpawnProfile_Record
	{
		[RED("despawnDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat DespawnDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawnDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
