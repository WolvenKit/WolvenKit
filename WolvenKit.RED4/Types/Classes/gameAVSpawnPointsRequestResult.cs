using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAVSpawnPointsRequestResult : RedBaseClass
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
		[RED("spawnPoints")] 
		public CArray<Vector3> SpawnPoints
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		public gameAVSpawnPointsRequestResult()
		{
			SpawnPoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
