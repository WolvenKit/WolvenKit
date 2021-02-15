using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAnimationTransforms : CVariable
	{
		[Ordinal(0)] [RED("extractedMotion")] public CArray<Transform> ExtractedMotion { get; set; }
		[Ordinal(1)] [RED("gatePosition")] public Transform GatePosition { get; set; }
		[Ordinal(2)] [RED("boneOffset")] public Transform BoneOffset { get; set; }
		[Ordinal(3)] [RED("animsetHash")] public CUInt64 AnimsetHash { get; set; }

		public gameAnimationTransforms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
