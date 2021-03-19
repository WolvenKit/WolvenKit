using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperationTriggerData : DeviceOperationTriggerData
	{
		private CBool _isActivatorPlayer;
		private CBool _isActivatorNPC;
		private CName _areaTag;
		private CEnum<gameinteractionsEInteractionEventType> _operationType;

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
		[RED("areaTag")] 
		public CName AreaTag
		{
			get => GetProperty(ref _areaTag);
			set => SetProperty(ref _areaTag, value);
		}

		[Ordinal(4)] 
		[RED("operationType")] 
		public CEnum<gameinteractionsEInteractionEventType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		public InteractionAreaOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
