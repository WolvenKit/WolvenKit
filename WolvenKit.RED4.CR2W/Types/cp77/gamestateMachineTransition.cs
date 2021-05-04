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
			get => GetProperty(ref _transitionCondition);
			set => SetProperty(ref _transitionCondition, value);
		}

		public gamestateMachineTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
