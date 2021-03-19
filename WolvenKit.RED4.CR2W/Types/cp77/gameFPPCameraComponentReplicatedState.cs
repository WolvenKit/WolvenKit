using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponentReplicatedState : netIComponentState
	{
		private CFloat _lookAtData_m_pitchInput;
		private CFloat _lookAtData_m_pitchRef;
		private CFloat _lookAtData_m_yawInput;
		private CFloat _lookAtData_m_yawRef;

		[Ordinal(2)] 
		[RED("lookAtData.m_pitchInput")] 
		public CFloat LookAtData_m_pitchInput
		{
			get => GetProperty(ref _lookAtData_m_pitchInput);
			set => SetProperty(ref _lookAtData_m_pitchInput, value);
		}

		[Ordinal(3)] 
		[RED("lookAtData.m_pitchRef")] 
		public CFloat LookAtData_m_pitchRef
		{
			get => GetProperty(ref _lookAtData_m_pitchRef);
			set => SetProperty(ref _lookAtData_m_pitchRef, value);
		}

		[Ordinal(4)] 
		[RED("lookAtData.m_yawInput")] 
		public CFloat LookAtData_m_yawInput
		{
			get => GetProperty(ref _lookAtData_m_yawInput);
			set => SetProperty(ref _lookAtData_m_yawInput, value);
		}

		[Ordinal(5)] 
		[RED("lookAtData.m_yawRef")] 
		public CFloat LookAtData_m_yawRef
		{
			get => GetProperty(ref _lookAtData_m_yawRef);
			set => SetProperty(ref _lookAtData_m_yawRef, value);
		}

		public gameFPPCameraComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
