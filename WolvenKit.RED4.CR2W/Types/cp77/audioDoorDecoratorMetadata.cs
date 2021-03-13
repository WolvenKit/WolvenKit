using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDoorDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("startOpen")] public CName StartOpen { get; set; }
		[Ordinal(2)] [RED("startClose")] public CName StartClose { get; set; }
		[Ordinal(3)] [RED("endOpen")] public CName EndOpen { get; set; }
		[Ordinal(4)] [RED("endClose")] public CName EndClose { get; set; }
		[Ordinal(5)] [RED("openLoop")] public CName OpenLoop { get; set; }
		[Ordinal(6)] [RED("closeLoop")] public CName CloseLoop { get; set; }
		[Ordinal(7)] [RED("openTime")] public CFloat OpenTime { get; set; }
		[Ordinal(8)] [RED("closeTime")] public CFloat CloseTime { get; set; }

		public audioDoorDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
