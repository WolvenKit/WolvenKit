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
			get
			{
				if (_coverNodeRef == null)
				{
					_coverNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "coverNodeRef", cr2w, this);
				}
				return _coverNodeRef;
			}
			set
			{
				if (_coverNodeRef == value)
				{
					return;
				}
				_coverNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get
			{
				if (_specialAction == null)
				{
					_specialAction = (CEnum<ECoverSpecialAction>) CR2WTypeManager.Create("ECoverSpecialAction", "specialAction", cr2w, this);
				}
				return _specialAction;
			}
			set
			{
				if (_specialAction == value)
				{
					return;
				}
				_specialAction = value;
				PropertySet(this);
			}
		}

		public AIMoveToCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
