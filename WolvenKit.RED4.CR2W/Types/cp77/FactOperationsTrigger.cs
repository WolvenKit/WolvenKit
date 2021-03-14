using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactOperationsTrigger : DeviceOperationsTrigger
	{
		private CHandle<FactOperationTriggerData> _triggerData;

		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<FactOperationTriggerData> TriggerData
		{
			get
			{
				if (_triggerData == null)
				{
					_triggerData = (CHandle<FactOperationTriggerData>) CR2WTypeManager.Create("handle:FactOperationTriggerData", "triggerData", cr2w, this);
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

		public FactOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
