using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectMembershipMemberShip : CVariable
	{
		[Ordinal(0)] [RED("hash")] public CUInt64 Hash { get; set; }
		[Ordinal(1)] [RED("index")] public CUInt32 Index { get; set; }

		public gameSmartObjectMembershipMemberShip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
