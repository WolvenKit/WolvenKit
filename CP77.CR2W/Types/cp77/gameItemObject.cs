using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemObject : gameTimeDilatable
	{
		[Ordinal(0)]  [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(1)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(2)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(3)]  [RED("updateBucket")] public CEnum<UpdateBucketEnum> UpdateBucket { get; set; }

		public gameItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
