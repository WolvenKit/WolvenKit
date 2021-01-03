using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointInfo : CVariable
	{
		[Ordinal(0)]  [RED("point")] public navSerializableSplineProgression Point { get; set; }
		[Ordinal(1)]  [RED("userDataIndex")] public CUInt32 UserDataIndex { get; set; }

		public navLocomotionPathPointInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
