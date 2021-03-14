using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharactersChain : CVariable
	{
		[Ordinal(0)] [RED("rarities")] public CArray<CUInt32> Rarities { get; set; }
		[Ordinal(1)] [RED("matchedValues")] public CUInt32 MatchedValues { get; set; }
		[Ordinal(2)] [RED("ownerId")] public CInt32 OwnerId { get; set; }
		[Ordinal(3)] [RED("isFulfilled")] public CBool IsFulfilled { get; set; }
		[Ordinal(4)] [RED("isPossible")] public CBool IsPossible { get; set; }

		public gameuiCharactersChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
