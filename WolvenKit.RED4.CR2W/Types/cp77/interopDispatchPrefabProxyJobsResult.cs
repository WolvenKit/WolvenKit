using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopDispatchPrefabProxyJobsResult : CVariable
	{
		[Ordinal(0)] [RED("numProxyJobsDispatched")] public CUInt32 NumProxyJobsDispatched { get; set; }
		[Ordinal(1)] [RED("numProxyJobsSkipped")] public CUInt32 NumProxyJobsSkipped { get; set; }
		[Ordinal(2)] [RED("numProxyJobsFailed")] public CUInt32 NumProxyJobsFailed { get; set; }

		public interopDispatchPrefabProxyJobsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
