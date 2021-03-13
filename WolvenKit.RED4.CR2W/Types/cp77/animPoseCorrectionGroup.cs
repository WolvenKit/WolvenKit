using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionGroup : CVariable
	{
		[Ordinal(0)] [RED("poseCorrections", 2)] public CStatic<animPoseCorrection> PoseCorrections { get; set; }

		public animPoseCorrectionGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
