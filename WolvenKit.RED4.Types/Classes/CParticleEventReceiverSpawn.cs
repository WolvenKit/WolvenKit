using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleEventReceiverSpawn : IParticleEvent
	{
		private CEnum<EParticleEventSpawnObject> _spawnObject;

		[Ordinal(4)] 
		[RED("spawnObject")] 
		public CEnum<EParticleEventSpawnObject> SpawnObject
		{
			get => GetProperty(ref _spawnObject);
			set => SetProperty(ref _spawnObject, value);
		}
	}
}
