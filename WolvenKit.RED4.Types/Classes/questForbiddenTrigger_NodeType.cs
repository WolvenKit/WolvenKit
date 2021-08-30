using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questForbiddenTrigger_NodeType : questIVehicleManagerNodeType
	{
		private NodeRef _triggerNodeRef;
		private CBool _activate;
		private CBool _dismount;

		[Ordinal(0)] 
		[RED("triggerNodeRef")] 
		public NodeRef TriggerNodeRef
		{
			get => GetProperty(ref _triggerNodeRef);
			set => SetProperty(ref _triggerNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("activate")] 
		public CBool Activate
		{
			get => GetProperty(ref _activate);
			set => SetProperty(ref _activate, value);
		}

		[Ordinal(2)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get => GetProperty(ref _dismount);
			set => SetProperty(ref _dismount, value);
		}

		public questForbiddenTrigger_NodeType()
		{
			_activate = true;
		}
	}
}
