using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleEventReceiverSpawn : IParticleEvent
	{
		[Ordinal(4)] 
		[RED("spawnObject")] 
		public CEnum<EParticleEventSpawnObject> SpawnObject
		{
			get => GetPropertyValue<CEnum<EParticleEventSpawnObject>>();
			set => SetPropertyValue<CEnum<EParticleEventSpawnObject>>(value);
		}

		public CParticleEventReceiverSpawn()
		{
			EditorName = "Event Receiver Spawn";
			EditorGroup = "Event";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
