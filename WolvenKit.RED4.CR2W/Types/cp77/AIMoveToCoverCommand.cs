using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCoverCommand : AIMoveCommand
	{
		private NodeRef _coverNodeRef;
		private CEnum<ECoverSpecialAction> _specialAction;

		[Ordinal(7)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get => GetProperty(ref _coverNodeRef);
			set => SetProperty(ref _coverNodeRef, value);
		}

		[Ordinal(8)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get => GetProperty(ref _specialAction);
			set => SetProperty(ref _specialAction, value);
		}

		public AIMoveToCoverCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
