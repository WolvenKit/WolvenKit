using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDSSSpawnRequestResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("requestID")] 
		public CUInt32 RequestID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("spawnedObjects")] 
		public CArray<CWeakHandle<gameObject>> SpawnedObjects
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		public gameDSSSpawnRequestResult()
		{
			SpawnedObjects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
