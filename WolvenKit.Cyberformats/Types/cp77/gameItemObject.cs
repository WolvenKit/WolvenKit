using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemObject : gameTimeDilatable
	{
		[Ordinal(40)] [RED("updateBucket")] public CEnum<UpdateBucketEnum> UpdateBucket { get; set; }
		[Ordinal(41)] [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(42)] [RED("isIconic")] public CBool IsIconic { get; set; }

		public gameItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
