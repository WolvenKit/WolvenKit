using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorParameterizedBehavior : ISerializable
	{
		[Ordinal(0)] 
		[RED("treeDefinition")] 
		public CResourceReference<AIbehaviorResource> TreeDefinition
		{
			get => GetPropertyValue<CResourceReference<AIbehaviorResource>>();
			set => SetPropertyValue<CResourceReference<AIbehaviorResource>>(value);
		}

		[Ordinal(1)] 
		[RED("argumentsOverrides")] 
		public CArray<AIArgumentOverrideWrapper> ArgumentsOverrides
		{
			get => GetPropertyValue<CArray<AIArgumentOverrideWrapper>>();
			set => SetPropertyValue<CArray<AIArgumentOverrideWrapper>>(value);
		}

		public AIbehaviorParameterizedBehavior()
		{
			ArgumentsOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
