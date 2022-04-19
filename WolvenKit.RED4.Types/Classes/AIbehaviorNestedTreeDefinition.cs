using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorNestedTreeDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("lateInitialization")] 
		public CBool LateInitialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("initializeOnEvent")] 
		public CArray<CName> InitializeOnEvent
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AIbehaviorNestedTreeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
