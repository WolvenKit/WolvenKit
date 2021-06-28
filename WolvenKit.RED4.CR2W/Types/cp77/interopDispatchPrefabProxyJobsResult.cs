using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopDispatchPrefabProxyJobsResult : CVariable
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

		public interopDispatchPrefabProxyJobsResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
