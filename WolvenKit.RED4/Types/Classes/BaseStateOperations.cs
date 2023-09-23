using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseStateOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("stateActionsOverrides")] 
		public SGenericDeviceActionsData StateActionsOverrides
		{
			get => GetPropertyValue<SGenericDeviceActionsData>();
			set => SetPropertyValue<SGenericDeviceActionsData>(value);
		}

		[Ordinal(3)] 
		[RED("baseStateOperations")] 
		public CArray<SBaseStateOperationData> BaseStateOperations_
		{
			get => GetPropertyValue<CArray<SBaseStateOperationData>>();
			set => SetPropertyValue<CArray<SBaseStateOperationData>>(value);
		}

		[Ordinal(4)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("cachedState")] 
		public CEnum<EDeviceStatus> CachedState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		public BaseStateOperations()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
