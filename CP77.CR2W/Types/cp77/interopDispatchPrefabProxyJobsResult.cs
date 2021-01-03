using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopDispatchPrefabProxyJobsResult : CVariable
	{
		[Ordinal(0)]  [RED("numProxyJobsDispatched")] public CUInt32 NumProxyJobsDispatched { get; set; }
		[Ordinal(1)]  [RED("numProxyJobsFailed")] public CUInt32 NumProxyJobsFailed { get; set; }
		[Ordinal(2)]  [RED("numProxyJobsSkipped")] public CUInt32 NumProxyJobsSkipped { get; set; }

		public interopDispatchPrefabProxyJobsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
