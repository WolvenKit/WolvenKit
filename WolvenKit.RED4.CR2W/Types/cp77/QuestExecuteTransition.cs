using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestExecuteTransition : redEvent
	{
		private AreaTypeTransition _transition;

		[Ordinal(0)] 
		[RED("transition")] 
		public AreaTypeTransition Transition
		{
			get
			{
				if (_transition == null)
				{
					_transition = (AreaTypeTransition) CR2WTypeManager.Create("AreaTypeTransition", "transition", cr2w, this);
				}
				return _transition;
			}
			set
			{
				if (_transition == value)
				{
					return;
				}
				_transition = value;
				PropertySet(this);
			}
		}

		public QuestExecuteTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
