using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class moveReplicatedMovePoliciesState : CVariable
	{
		[Ordinal(0)]  [RED("items")] public CArray<moveReplicatedMovePolicies> Items { get; set; }
		[Ordinal(1)]  [RED("lastAppliedActionsTime")] public netTime LastAppliedActionsTime { get; set; }

		public moveReplicatedMovePoliciesState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
