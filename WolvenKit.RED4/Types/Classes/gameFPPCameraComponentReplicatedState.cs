using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFPPCameraComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("lookAtData.m_pitchInput")] 
		public CFloat LookAtData_m_pitchInput
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lookAtData.m_pitchRef")] 
		public CFloat LookAtData_m_pitchRef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lookAtData.m_yawInput")] 
		public CFloat LookAtData_m_yawInput
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("lookAtData.m_yawRef")] 
		public CFloat LookAtData_m_yawRef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameFPPCameraComponentReplicatedState()
		{
			Enabled = true;
			LookAtData_m_pitchInput = 999.000000F;
			LookAtData_m_pitchRef = 999.000000F;
			LookAtData_m_yawInput = 999.000000F;
			LookAtData_m_yawRef = 999.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
