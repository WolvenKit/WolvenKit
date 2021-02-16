using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioPlayerInVehicleASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] [RED("isInside")] public CBool IsInside { get; set; }

		public audioPlayerInVehicleASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
