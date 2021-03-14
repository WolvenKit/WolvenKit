using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AssignRestrictMovementAreaTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _restrictMovementAreaRef;

		[Ordinal(0)] 
		[RED("restrictMovementAreaRef")] 
		public CHandle<AIArgumentMapping> RestrictMovementAreaRef
		{
			get
			{
				if (_restrictMovementAreaRef == null)
				{
					_restrictMovementAreaRef = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "restrictMovementAreaRef", cr2w, this);
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

		public AssignRestrictMovementAreaTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
