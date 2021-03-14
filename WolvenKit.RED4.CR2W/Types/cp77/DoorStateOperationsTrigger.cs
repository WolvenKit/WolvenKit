using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperationsTrigger : DeviceOperationsTrigger
	{
		private CHandle<DoorStateOperationTriggerData> _triggerData;
		private CBool _wasStateCached;
		private CEnum<EDoorStatus> _cachedState;

		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<DoorStateOperationTriggerData> TriggerData
		{
			get
			{
				if (_triggerData == null)
				{
					_triggerData = (CHandle<DoorStateOperationTriggerData>) CR2WTypeManager.Create("handle:DoorStateOperationTriggerData", "triggerData", cr2w, this);
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

		[Ordinal(1)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get
			{
				if (_wasStateCached == null)
				{
					_wasStateCached = (CBool) CR2WTypeManager.Create("Bool", "wasStateCached", cr2w, this);
				}
				return _wasStateCached;
			}
			set
			{
				if (_wasStateCached == value)
				{
					return;
				}
				_wasStateCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cachedState")] 
		public CEnum<EDoorStatus> CachedState
		{
			get
			{
				if (_cachedState == null)
				{
					_cachedState = (CEnum<EDoorStatus>) CR2WTypeManager.Create("EDoorStatus", "cachedState", cr2w, this);
				}
				return _cachedState;
			}
			set
			{
				if (_cachedState == value)
				{
					return;
				}
				_cachedState = value;
				PropertySet(this);
			}
		}

		public DoorStateOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
