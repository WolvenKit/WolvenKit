using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemViewData : CVariable
	{
		[Ordinal(0)] [RED("id")] public gameItemID Id { get; set; }
		[Ordinal(1)] [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(2)] [RED("categoryName")] public CString CategoryName { get; set; }
		[Ordinal(3)] [RED("description")] public CString Description { get; set; }
		[Ordinal(4)] [RED("quality")] public CString Quality { get; set; }
		[Ordinal(5)] [RED("price")] public CFloat Price { get; set; }
		[Ordinal(6)] [RED("isBroken")] public CBool IsBroken { get; set; }
		[Ordinal(7)] [RED("primaryStats")] public CArray<gameStatViewData> PrimaryStats { get; set; }
		[Ordinal(8)] [RED("secondaryStats")] public CArray<gameStatViewData> SecondaryStats { get; set; }
		[Ordinal(9)] [RED("comparedQuality")] public CEnum<gamedataQuality> ComparedQuality { get; set; }

		public gameItemViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
