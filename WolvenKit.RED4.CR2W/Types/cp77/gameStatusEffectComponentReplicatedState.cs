using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("replicatedInfo")] public CArray<gameStatusEffectReplicatedInfo> ReplicatedInfo { get; set; }

		public gameStatusEffectComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
