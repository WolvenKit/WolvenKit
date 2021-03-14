using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNewsFeedElementData : CVariable
	{
		[Ordinal(0)] [RED("banners")] public CArray<SsimpleBanerData> Banners { get; set; }
		[Ordinal(1)] [RED("currentBanner")] public CInt32 CurrentBanner { get; set; }

		public SNewsFeedElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
