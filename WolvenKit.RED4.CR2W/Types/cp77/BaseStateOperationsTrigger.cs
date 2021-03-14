using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperationsTrigger : DeviceOperationsTrigger
	{
		private CHandle<BaseStateOperationTriggerData> _triggerData;
		private CBool _wasStateCached;
		private CEnum<EDeviceStatus> _cachedState;

		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<BaseStateOperationTriggerData> TriggerData
		{
			get
			{
				if (_triggerData == null)
				{
					_triggerData = (CHandle<BaseStateOperationTriggerData>) CR2WTypeManager.Create("handle:BaseStateOperationTriggerData", "triggerData", cr2w, this);
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
		public CEnum<EDeviceStatus> CachedState
		{
			get
			{
				if (_cachedState == null)
				{
					_cachedState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "cachedState", cr2w, this);
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

		public BaseStateOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
