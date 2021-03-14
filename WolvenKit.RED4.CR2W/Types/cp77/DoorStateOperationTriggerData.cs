using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<EDoorStatus> _state;

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EDoorStatus>) CR2WTypeManager.Create("EDoorStatus", "state", cr2w, this);
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

		public DoorStateOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
