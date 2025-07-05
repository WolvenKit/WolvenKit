using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopDispatchPrefabProxyJobsResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numProxyJobsDispatched")] 
		public CUInt32 NumProxyJobsDispatched
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("numProxyJobsSkipped")] 
		public CUInt32 NumProxyJobsSkipped
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("numProxyJobsFailed")] 
		public CUInt32 NumProxyJobsFailed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public interopDispatchPrefabProxyJobsResult()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
