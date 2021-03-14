using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceActionOperationsTrigger : DeviceOperationsTrigger
	{
		private CHandle<DeviceActionOperationTriggerData> _triggerData;

		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<DeviceActionOperationTriggerData> TriggerData
		{
			get
			{
				if (_triggerData == null)
				{
					_triggerData = (CHandle<DeviceActionOperationTriggerData>) CR2WTypeManager.Create("handle:DeviceActionOperationTriggerData", "triggerData", cr2w, this);
				}
				return _triggerData;
			}
			set
			{
				if (_triggerData == value)
				{
					return;
				}
				_triggerData = value;
				PropertySet(this);
			}
		}

		public DeviceActionOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
