using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAssignTaskItem : CVariable
	{
		private CHandle<AIArgumentMapping> _leftHandSide;
		private CHandle<AIArgumentMapping> _rightHandSide;

		[Ordinal(0)] 
		[RED("leftHandSide")] 
		public CHandle<AIArgumentMapping> LeftHandSide
		{
			get => GetProperty(ref _leftHandSide);
			set => SetProperty(ref _leftHandSide, value);
		}

		[Ordinal(1)] 
		[RED("rightHandSide")] 
		public CHandle<AIArgumentMapping> RightHandSide
		{
			get => GetProperty(ref _rightHandSide);
			set => SetProperty(ref _rightHandSide, value);
		}

		public AIbehaviorAssignTaskItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
