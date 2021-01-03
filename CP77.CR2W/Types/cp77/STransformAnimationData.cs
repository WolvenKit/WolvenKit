using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationData : CVariable
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("operationType")] public CEnum<ETransformAnimationOperationType> OperationType { get; set; }
		[Ordinal(2)]  [RED("playData")] public STransformAnimationPlayEventData PlayData { get; set; }
		[Ordinal(3)]  [RED("skipData")] public STransformAnimationSkipEventData SkipData { get; set; }

		public STransformAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
