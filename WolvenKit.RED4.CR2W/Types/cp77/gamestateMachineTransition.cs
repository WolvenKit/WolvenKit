using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineTransition : graphGraphConnectionDefinition
	{
		private CHandle<gamestateMachineFunctor> _transitionCondition;

		[Ordinal(2)] 
		[RED("transitionCondition")] 
		public CHandle<gamestateMachineFunctor> TransitionCondition
		{
			get
			{
				if (_transitionCondition == null)
				{
					_transitionCondition = (CHandle<gamestateMachineFunctor>) CR2WTypeManager.Create("handle:gamestateMachineFunctor", "transitionCondition", cr2w, this);
				}
				return _transitionCondition;
			}
			set
			{
				if (_transitionCondition == value)
				{
					return;
				}
				_transitionCondition = value;
				PropertySet(this);
			}
		}

		public gamestateMachineTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
