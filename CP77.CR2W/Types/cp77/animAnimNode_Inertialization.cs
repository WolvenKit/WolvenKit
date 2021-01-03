using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Inertialization : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("rotationLimits")] public CArray<animInertializationRotationLimit> RotationLimits { get; set; }
		[Ordinal(1)]  [RED("safeMode")] public CBool SafeMode { get; set; }
		[Ordinal(2)]  [RED("tracksCountUpperBound")] public CUInt32 TracksCountUpperBound { get; set; }
		[Ordinal(3)]  [RED("transformsCountUpperBound")] public CUInt32 TransformsCountUpperBound { get; set; }

		public animAnimNode_Inertialization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
