using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("WeakspotRepInfos")] public CArray<gameWeakSpotReplicatedInfo> WeakspotRepInfos { get; set; }

		public gameWeakspotComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
