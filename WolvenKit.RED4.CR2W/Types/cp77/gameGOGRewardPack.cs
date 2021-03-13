using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGOGRewardPack : CVariable
	{
		[Ordinal(0)] [RED("id")] public CString Id { get; set; }
		[Ordinal(1)] [RED("title")] public CString Title { get; set; }
		[Ordinal(2)] [RED("reason")] public CString Reason { get; set; }
		[Ordinal(3)] [RED("iconSlot")] public CName IconSlot { get; set; }
		[Ordinal(4)] [RED("rewards")] public CArray<CUInt64> Rewards { get; set; }

		public gameGOGRewardPack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
