using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questElevator_ManageNPCAttachment_NodeTypeParams : CVariable
	{
		private NodeRef _elevatorRef;
		private gameEntityReference _npcRef;
		private CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> _action;

		[Ordinal(0)] 
		[RED("elevatorRef")] 
		public NodeRef ElevatorRef
		{
			get => GetProperty(ref _elevatorRef);
			set => SetProperty(ref _elevatorRef, value);
		}

		[Ordinal(1)] 
		[RED("npcRef")] 
		public gameEntityReference NpcRef
		{
			get => GetProperty(ref _npcRef);
			set => SetProperty(ref _npcRef, value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public questElevator_ManageNPCAttachment_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
