using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemObject : gameTimeDilatable
	{
		[Ordinal(0)]  [RED("updateBucket")] public CEnum<UpdateBucketEnum> UpdateBucket { get; set; }

		public gameItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
