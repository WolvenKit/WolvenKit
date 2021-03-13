using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Bounty : CVariable
	{
		[Ordinal(0)] [RED("transgressions")] public CArray<TweakDBID> Transgressions { get; set; }
		[Ordinal(1)] [RED("bountySetter")] public TweakDBID BountySetter { get; set; }
		[Ordinal(2)] [RED("moneyAmount")] public CInt32 MoneyAmount { get; set; }
		[Ordinal(3)] [RED("streetCredAmount")] public CInt32 StreetCredAmount { get; set; }
		[Ordinal(4)] [RED("awarded")] public CBool Awarded { get; set; }
		[Ordinal(5)] [RED("wantedStars")] public CInt32 WantedStars { get; set; }

		public Bounty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
