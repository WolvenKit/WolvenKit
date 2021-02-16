using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("lookAtData.m_pitchInput")] public CFloat LookAtData_m_pitchInput { get; set; }
		[Ordinal(3)] [RED("lookAtData.m_pitchRef")] public CFloat LookAtData_m_pitchRef { get; set; }
		[Ordinal(4)] [RED("lookAtData.m_yawInput")] public CFloat LookAtData_m_yawInput { get; set; }
		[Ordinal(5)] [RED("lookAtData.m_yawRef")] public CFloat LookAtData_m_yawRef { get; set; }

		public gameFPPCameraComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
