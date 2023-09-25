using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AVSpawnedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("spawnedObjects")] 
		public CArray<CWeakHandle<gameObject>> SpawnedObjects
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		public AVSpawnedRequest()
		{
			SpawnedObjects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
