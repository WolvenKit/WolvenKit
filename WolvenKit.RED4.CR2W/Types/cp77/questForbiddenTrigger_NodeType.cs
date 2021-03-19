using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForbiddenTrigger_NodeType : questIVehicleManagerNodeType
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

		public questForbiddenTrigger_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
