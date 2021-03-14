using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshCLSOnSlavesEvent : redEvent
	{
		private CArray<CHandle<gameDeviceComponentPS>> _slaves;
		private CEnum<EDeviceStatus> _state;
		private CBool _restorePower;

		[Ordinal(0)] 
		[RED("slaves")] 
		public CArray<CHandle<gameDeviceComponentPS>> Slaves
		{
			get
			{
				if (_slaves == null)
				{
					_slaves = (CArray<CHandle<gameDeviceComponentPS>>) CR2WTypeManager.Create("array:handle:gameDeviceComponentPS", "slaves", cr2w, this);
				}
				return _slaves;
			}
			set
			{
				if (_slaves == value)
				{
					return;
				}
				_slaves = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public RefreshCLSOnSlavesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
