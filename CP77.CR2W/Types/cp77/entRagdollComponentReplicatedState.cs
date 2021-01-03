using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entRagdollComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("isSleeping")] public CBool IsSleeping { get; set; }
		[Ordinal(1)]  [RED("transforms")] public CArray<Transform> Transforms { get; set; }

		public entRagdollComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
