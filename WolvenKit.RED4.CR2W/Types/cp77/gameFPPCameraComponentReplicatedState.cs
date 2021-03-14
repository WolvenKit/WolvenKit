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
			get
			{
				if (_lookAtData_m_pitchInput == null)
				{
					_lookAtData_m_pitchInput = (CFloat) CR2WTypeManager.Create("Float", "lookAtData.m_pitchInput", cr2w, this);
				}
				return _lookAtData_m_pitchInput;
			}
			set
			{
				if (_lookAtData_m_pitchInput == value)
				{
					return;
				}
				_lookAtData_m_pitchInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lookAtData.m_pitchRef")] 
		public CFloat LookAtData_m_pitchRef
		{
			get
			{
				if (_lookAtData_m_pitchRef == null)
				{
					_lookAtData_m_pitchRef = (CFloat) CR2WTypeManager.Create("Float", "lookAtData.m_pitchRef", cr2w, this);
				}
				return _lookAtData_m_pitchRef;
			}
			set
			{
				if (_lookAtData_m_pitchRef == value)
				{
					return;
				}
				_lookAtData_m_pitchRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lookAtData.m_yawInput")] 
		public CFloat LookAtData_m_yawInput
		{
			get
			{
				if (_lookAtData_m_yawInput == null)
				{
					_lookAtData_m_yawInput = (CFloat) CR2WTypeManager.Create("Float", "lookAtData.m_yawInput", cr2w, this);
				}
				return _lookAtData_m_yawInput;
			}
			set
			{
				if (_lookAtData_m_yawInput == value)
				{
					return;
				}
				_lookAtData_m_yawInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lookAtData.m_yawRef")] 
		public CFloat LookAtData_m_yawRef
		{
			get
			{
				if (_lookAtData_m_yawRef == null)
				{
					_lookAtData_m_yawRef = (CFloat) CR2WTypeManager.Create("Float", "lookAtData.m_yawRef", cr2w, this);
				}
				return _lookAtData_m_yawRef;
			}
			set
			{
				if (_lookAtData_m_yawRef == value)
				{
					return;
				}
				_lookAtData_m_yawRef = value;
				PropertySet(this);
			}
		}

		public gameFPPCameraComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
