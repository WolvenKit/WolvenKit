using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointInfo : CVariable
	{
		[Ordinal(0)] [RED("point")] public navSerializableSplineProgression Point { get; set; }
		[Ordinal(1)] [RED("userDataIndex")] public CUInt32 UserDataIndex { get; set; }

		public navLocomotionPathPointInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
