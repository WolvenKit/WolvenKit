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
		public CEnum<EDoorStatus> CachedState
		{
			get => GetProperty(ref _cachedState);
			set => SetProperty(ref _cachedState, value);
		}

		public DoorStateOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
