using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Retarget : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("postProcess")] public CHandle<animIAnimNode_PostProcess> PostProcess { get; set; }
		[Ordinal(1)]  [RED("refRig")] public rRef<animRig> RefRig { get; set; }

		public animAnimNode_Retarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
