using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveReplicatedMovePolicies : entReplicatedItem
	{
		[Ordinal(2)] [RED("key")] public CUInt64 Key { get; set; }
		[Ordinal(3)] [RED("policies")] public CHandle<movePolicies> Policies { get; set; }

		public moveReplicatedMovePolicies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
