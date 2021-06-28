using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerVolumeOperationTriggerData : DeviceOperationTriggerData
	{
		private CBool _isActivatorPlayer;
		private CBool _isActivatorNPC;
		private CBool _canNPCBeDead;
		private CName _componentName;
		private CEnum<ETriggerOperationType> _operationType;

		[Ordinal(1)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get => GetProperty(ref _isActivatorPlayer);
			set => SetProperty(ref _isActivatorPlayer, value);
		}

		[Ordinal(2)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get => GetProperty(ref _isActivatorNPC);
			set => SetProperty(ref _isActivatorNPC, value);
		}

		[Ordinal(3)] 
		[RED("canNPCBeDead")] 
		public CBool CanNPCBeDead
		{
			get => GetProperty(ref _canNPCBeDead);
			set => SetProperty(ref _canNPCBeDead, value);
		}

		[Ordinal(4)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(5)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		public TriggerVolumeOperationTriggerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
