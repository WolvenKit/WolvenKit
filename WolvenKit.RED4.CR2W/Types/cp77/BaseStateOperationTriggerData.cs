using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<EDeviceStatus> _state;

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

		public BaseStateOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
