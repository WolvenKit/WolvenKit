using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntitySpawnerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("spawnedEntityId")] 
		public entEntityID SpawnedEntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<gameEntitySpawnerEventType> EventType
		{
			get => GetPropertyValue<CEnum<gameEntitySpawnerEventType>>();
			set => SetPropertyValue<CEnum<gameEntitySpawnerEventType>>(value);
		}

		public gameEntitySpawnerEvent()
		{
			SpawnedEntityId = new();
			EventType = Enums.gameEntitySpawnerEventType.Spawn;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
