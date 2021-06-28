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
			get => GetProperty(ref _triggerData);
			set => SetProperty(ref _triggerData, value);
		}

		[Ordinal(1)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetProperty(ref _wasStateCached);
			set => SetProperty(ref _wasStateCached, value);
		}

		[Ordinal(2)] 
		[RED("cachedState")] 
		public CEnum<EDeviceStatus> CachedState
		{
			get => GetProperty(ref _cachedState);
			set => SetProperty(ref _cachedState, value);
		}

		public BaseStateOperationsTrigger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
