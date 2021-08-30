using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFPPCameraComponentReplicatedState : netIComponentState
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

		public gameFPPCameraComponentReplicatedState()
		{
			_lookAtData_m_pitchInput = 999.000000F;
			_lookAtData_m_pitchRef = 999.000000F;
			_lookAtData_m_yawInput = 999.000000F;
			_lookAtData_m_yawRef = 999.000000F;
		}
	}
}
