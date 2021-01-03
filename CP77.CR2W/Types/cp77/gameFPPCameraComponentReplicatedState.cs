using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("lookAtData.m_pitchInput")] public CFloat PitchInput { get; set; }
		[Ordinal(1)]  [RED("lookAtData.m_pitchRef")] public CFloat PitchRef { get; set; }
		[Ordinal(2)]  [RED("lookAtData.m_yawInput")] public CFloat YawInput { get; set; }
		[Ordinal(3)]  [RED("lookAtData.m_yawRef")] public CFloat YawRef { get; set; }

		public gameFPPCameraComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
