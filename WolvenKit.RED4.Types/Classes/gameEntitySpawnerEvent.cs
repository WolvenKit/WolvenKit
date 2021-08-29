using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntitySpawnerEvent : redEvent
	{
		private entEntityID _spawnedEntityId;
		private CEnum<gameEntitySpawnerEventType> _eventType;

		[Ordinal(0)] 
		[RED("spawnedEntityId")] 
		public entEntityID SpawnedEntityId
		{
			get => GetProperty(ref _spawnedEntityId);
			set => SetProperty(ref _spawnedEntityId, value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<gameEntitySpawnerEventType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}
	}
}
