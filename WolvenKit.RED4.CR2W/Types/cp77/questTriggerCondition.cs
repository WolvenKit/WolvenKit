using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTriggerCondition : questCondition
	{
		private CEnum<questTriggerConditionType> _type;
		private NodeRef _triggerAreaRef;
		private gameEntityReference _activatorRef;
		private CBool _isPlayerActivator;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questTriggerConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("triggerAreaRef")] 
		public NodeRef TriggerAreaRef
		{
			get => GetProperty(ref _triggerAreaRef);
			set => SetProperty(ref _triggerAreaRef, value);
		}

		[Ordinal(2)] 
		[RED("activatorRef")] 
		public gameEntityReference ActivatorRef
		{
			get => GetProperty(ref _activatorRef);
			set => SetProperty(ref _activatorRef, value);
		}

		[Ordinal(3)] 
		[RED("isPlayerActivator")] 
		public CBool IsPlayerActivator
		{
			get => GetProperty(ref _isPlayerActivator);
			set => SetProperty(ref _isPlayerActivator, value);
		}

		public questTriggerCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
