using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDoorDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("closeLoop")] public CName CloseLoop { get; set; }
		[Ordinal(1)]  [RED("closeTime")] public CFloat CloseTime { get; set; }
		[Ordinal(2)]  [RED("endClose")] public CName EndClose { get; set; }
		[Ordinal(3)]  [RED("endOpen")] public CName EndOpen { get; set; }
		[Ordinal(4)]  [RED("openLoop")] public CName OpenLoop { get; set; }
		[Ordinal(5)]  [RED("openTime")] public CFloat OpenTime { get; set; }
		[Ordinal(6)]  [RED("startClose")] public CName StartClose { get; set; }
		[Ordinal(7)]  [RED("startOpen")] public CName StartOpen { get; set; }

		public audioDoorDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
