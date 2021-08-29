using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeSpawnCompletedEvent : redEvent
	{
		private CWeakHandle<gameObject> _spawnedObject;

		[Ordinal(0)] 
		[RED("spawnedObject")] 
		public CWeakHandle<gameObject> SpawnedObject
		{
			get => GetProperty(ref _spawnedObject);
			set => SetProperty(ref _spawnedObject, value);
		}
	}
}
