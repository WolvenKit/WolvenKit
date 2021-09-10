using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeSpawnCompletedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("spawnedObject")] 
		public CWeakHandle<gameObject> SpawnedObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
