using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAgentSpawnedEvent : redEvent
	{
		private DeviceLink _spawnedAgent;
		private CEnum<gameEntitySpawnerEventType> _eventType;
		private CArray<CHandle<SecurityAreaControllerPS>> _securityAreas;

		[Ordinal(0)] 
		[RED("spawnedAgent")] 
		public DeviceLink SpawnedAgent
		{
			get => GetProperty(ref _spawnedAgent);
			set => SetProperty(ref _spawnedAgent, value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<gameEntitySpawnerEventType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		[Ordinal(2)] 
		[RED("securityAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> SecurityAreas
		{
			get => GetProperty(ref _securityAreas);
			set => SetProperty(ref _securityAreas, value);
		}
	}
}
