using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAssignTaskItem : RedBaseClass
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
	}
}
