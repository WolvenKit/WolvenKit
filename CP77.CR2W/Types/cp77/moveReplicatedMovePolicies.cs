using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class moveReplicatedMovePolicies : entReplicatedItem
	{
		[Ordinal(0)]  [RED("key")] public CUInt64 Key { get; set; }
		[Ordinal(1)]  [RED("policies")] public CHandle<movePolicies> Policies { get; set; }

		public moveReplicatedMovePolicies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
