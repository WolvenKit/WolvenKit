using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAssignTaskItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("leftHandSide")] 
		public CHandle<AIArgumentMapping> LeftHandSide
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("rightHandSide")] 
		public CHandle<AIArgumentMapping> RightHandSide
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
