using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("WeakspotRepInfos")] public CArray<gameWeakSpotReplicatedInfo> WeakspotRepInfos { get; set; }

		public gameWeakspotComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
