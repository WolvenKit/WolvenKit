using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveMovePoliciesComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("movePolicies")] public moveReplicatedMovePoliciesState MovePolicies { get; set; }

		public moveMovePoliciesComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
