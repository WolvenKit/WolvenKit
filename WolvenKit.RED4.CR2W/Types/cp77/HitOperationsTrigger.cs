using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitOperationsTrigger : DeviceOperationsTrigger
	{
		private CHandle<HitOperationTriggerData> _triggerData;

		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<HitOperationTriggerData> TriggerData
		{
			get
			{
				if (_triggerData == null)
				{
					_triggerData = (CHandle<HitOperationTriggerData>) CR2WTypeManager.Create("handle:HitOperationTriggerData", "triggerData", cr2w, this);
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

		public HitOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
