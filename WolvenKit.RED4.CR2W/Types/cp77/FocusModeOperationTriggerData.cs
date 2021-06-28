using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<ETriggerOperationType> _operationType;
		private CBool _isLookedAt;

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(2)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetProperty(ref _isLookedAt);
			set => SetProperty(ref _isLookedAt, value);
		}

		public FocusModeOperationTriggerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
