using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperationsTrigger : DeviceOperationsTrigger
	{
		private CHandle<FocusModeOperationTriggerData> _triggerData;

		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<FocusModeOperationTriggerData> TriggerData
		{
			get => GetProperty(ref _triggerData);
			set => SetProperty(ref _triggerData, value);
		}

		public FocusModeOperationsTrigger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
