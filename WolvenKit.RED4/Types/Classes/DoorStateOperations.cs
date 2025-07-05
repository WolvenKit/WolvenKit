using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorStateOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("doorStateOperations")] 
		public CArray<SDoorStateOperationData> DoorStateOperations_
		{
			get => GetPropertyValue<CArray<SDoorStateOperationData>>();
			set => SetPropertyValue<CArray<SDoorStateOperationData>>(value);
		}

		[Ordinal(3)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("cachedState")] 
		public CEnum<EDoorStatus> CachedState
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		public DoorStateOperations()
		{
			Components = new();
			FxInstances = new();
			DoorStateOperations_ = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
