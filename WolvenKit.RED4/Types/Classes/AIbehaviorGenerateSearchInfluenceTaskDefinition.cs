using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorGenerateSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("position")] 
		public CHandle<AIArgumentMapping> Position
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CHandle<AIArgumentMapping> Radius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorGenerateSearchInfluenceTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
