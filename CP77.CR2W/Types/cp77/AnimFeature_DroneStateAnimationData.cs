using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneStateAnimationData : animAnimFeature
	{
		[Ordinal(0)] [RED("statePose")] public CInt32 StatePose { get; set; }

		public AnimFeature_DroneStateAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
