using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animBoneTraceCondition : ISerializable
	{
		[Ordinal(0)] [RED("boneIndex")] public CInt16 BoneIndex { get; set; }
		[Ordinal(1)] [RED("traceByRotation")] public CBool TraceByRotation { get; set; }
		[Ordinal(2)] [RED("rotationAngleTolerance")] public CFloat RotationAngleTolerance { get; set; }
		[Ordinal(3)] [RED("traceByTranslation")] public CBool TraceByTranslation { get; set; }
		[Ordinal(4)] [RED("translationTolerance")] public CFloat TranslationTolerance { get; set; }

		public animBoneTraceCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
