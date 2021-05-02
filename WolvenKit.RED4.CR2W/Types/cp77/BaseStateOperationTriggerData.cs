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
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public BaseStateOperationTriggerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
