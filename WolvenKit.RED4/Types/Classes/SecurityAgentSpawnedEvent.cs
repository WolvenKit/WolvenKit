using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAgentSpawnedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("spawnedAgent")] 
		public DeviceLink SpawnedAgent
		{
			get => GetPropertyValue<DeviceLink>();
			set => SetPropertyValue<DeviceLink>(value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<gameEntitySpawnerEventType> EventType
		{
			get => GetPropertyValue<CEnum<gameEntitySpawnerEventType>>();
			set => SetPropertyValue<CEnum<gameEntitySpawnerEventType>>(value);
		}

		[Ordinal(2)] 
		[RED("securityAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> SecurityAreas
		{
			get => GetPropertyValue<CArray<CHandle<SecurityAreaControllerPS>>>();
			set => SetPropertyValue<CArray<CHandle<SecurityAreaControllerPS>>>(value);
		}

		public SecurityAgentSpawnedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
