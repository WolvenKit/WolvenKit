using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questScan_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private CEnum<questObjectScanEventType> _eventType;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questObjectScanEventType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<questObjectScanEventType>) CR2WTypeManager.Create("questObjectScanEventType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		public questScan_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
