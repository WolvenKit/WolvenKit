using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEvent : scnPlayFPPControlAnimEvent
	{
		[Ordinal(0)]  [RED("animName")] public CHandle<scnAnimName> AnimName { get; set; }
		[Ordinal(1)]  [RED("playerData")] public scnPlayerAnimData PlayerData { get; set; }
		[Ordinal(2)]  [RED("poseBlendOutWorkspot")] public CHandle<scnEventBlendWorkspotSetupParameters> PoseBlendOutWorkspot { get; set; }
		[Ordinal(3)]  [RED("rootMotionData")] public scnPlaySkAnimRootMotionData RootMotionData { get; set; }

		public scnPlaySkAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
