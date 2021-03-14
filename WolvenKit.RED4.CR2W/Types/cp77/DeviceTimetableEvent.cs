using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceTimetableEvent : redEvent
	{
		private CEnum<EDeviceStatus> _state;
		private entEntityID _requesterID;
		private CBool _restorePower;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get
			{
				if (_requesterID == null)
				{
					_requesterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "requesterID", cr2w, this);
				}
				return _requesterID;
			}
			set
			{
				if (_requesterID == value)
				{
					return;
				}
				_requesterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("restorePower")] 
		public CBool RestorePower
		{
			get
			{
				if (_restorePower == null)
				{
					_restorePower = (CBool) CR2WTypeManager.Create("Bool", "restorePower", cr2w, this);
				}
				return _restorePower;
			}
			set
			{
				if (_restorePower == value)
				{
					return;
				}
				_restorePower = value;
				PropertySet(this);
			}
		}

		public DeviceTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
