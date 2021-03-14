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
			get
			{
				if (_restrictMovementAreaRef == null)
				{
					_restrictMovementAreaRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "restrictMovementAreaRef", cr2w, this);
				}
				return _restrictMovementAreaRef;
			}
			set
			{
				if (_restrictMovementAreaRef == value)
				{
					return;
				}
				_restrictMovementAreaRef = value;
				PropertySet(this);
			}
		}

		public AIAssignGuardAreaCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
