using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionRotateByAngleTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("angle")] 
		public CHandle<AIArgumentMapping> Angle
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("angleTolerance")] 
		public CHandle<AIArgumentMapping> AngleTolerance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionRotateByAngleTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
