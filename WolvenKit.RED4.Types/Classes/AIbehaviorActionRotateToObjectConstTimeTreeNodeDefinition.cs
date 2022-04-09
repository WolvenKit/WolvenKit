using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionRotateToObjectConstTimeTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("angleOffset")] 
		public CHandle<AIArgumentMapping> AngleOffset
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("angleTolerance")] 
		public CHandle<AIArgumentMapping> AngleTolerance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("time")] 
		public CHandle<AIArgumentMapping> Time
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("keepUpdatingTarget")] 
		public CHandle<AIArgumentMapping> KeepUpdatingTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionRotateToObjectConstTimeTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
