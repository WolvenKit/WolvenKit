using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopDispatchPrefabProxyJobsResult : RedBaseClass
	{
		private CUInt32 _numProxyJobsDispatched;
		private CUInt32 _numProxyJobsSkipped;
		private CUInt32 _numProxyJobsFailed;

		[Ordinal(0)] 
		[RED("numProxyJobsDispatched")] 
		public CUInt32 NumProxyJobsDispatched
		{
			get => GetProperty(ref _numProxyJobsDispatched);
			set => SetProperty(ref _numProxyJobsDispatched, value);
		}

		[Ordinal(1)] 
		[RED("numProxyJobsSkipped")] 
		public CUInt32 NumProxyJobsSkipped
		{
			get => GetProperty(ref _numProxyJobsSkipped);
			set => SetProperty(ref _numProxyJobsSkipped, value);
		}

		[Ordinal(2)] 
		[RED("numProxyJobsFailed")] 
		public CUInt32 NumProxyJobsFailed
		{
			get => GetProperty(ref _numProxyJobsFailed);
			set => SetProperty(ref _numProxyJobsFailed, value);
		}
	}
}
