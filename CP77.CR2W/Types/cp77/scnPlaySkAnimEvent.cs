using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEvent : scnPlayFPPControlAnimEvent
	{
		[Ordinal(31)] [RED("animName")] public CHandle<scnAnimName> AnimName { get; set; }
		[Ordinal(32)] [RED("poseBlendOutWorkspot")] public CHandle<scnEventBlendWorkspotSetupParameters> PoseBlendOutWorkspot { get; set; }
		[Ordinal(33)] [RED("rootMotionData")] public scnPlaySkAnimRootMotionData RootMotionData { get; set; }
		[Ordinal(34)] [RED("playerData")] public scnPlayerAnimData PlayerData { get; set; }

		public scnPlaySkAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
