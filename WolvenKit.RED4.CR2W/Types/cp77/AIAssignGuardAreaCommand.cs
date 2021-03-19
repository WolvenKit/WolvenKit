using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAssignGuardAreaCommand : AICommand
	{
		private NodeRef _restrictMovementAreaRef;

		[Ordinal(4)] 
		[RED("restrictMovementAreaRef")] 
		public NodeRef RestrictMovementAreaRef
		{
			get => GetProperty(ref _restrictMovementAreaRef);
			set => SetProperty(ref _restrictMovementAreaRef, value);
		}

		public AIAssignGuardAreaCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
