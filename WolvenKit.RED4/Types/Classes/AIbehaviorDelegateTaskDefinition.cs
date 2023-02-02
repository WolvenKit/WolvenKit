using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDelegateTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("onActivate")] 
		public AIbehaviorDelegateTaskRef OnActivate
		{
			get => GetPropertyValue<AIbehaviorDelegateTaskRef>();
			set => SetPropertyValue<AIbehaviorDelegateTaskRef>(value);
		}

		[Ordinal(2)] 
		[RED("onUpdate")] 
		public AIbehaviorDelegateTaskRef OnUpdate
		{
			get => GetPropertyValue<AIbehaviorDelegateTaskRef>();
			set => SetPropertyValue<AIbehaviorDelegateTaskRef>(value);
		}

		[Ordinal(3)] 
		[RED("onDeactivate")] 
		public AIbehaviorDelegateTaskRef OnDeactivate
		{
			get => GetPropertyValue<AIbehaviorDelegateTaskRef>();
			set => SetPropertyValue<AIbehaviorDelegateTaskRef>(value);
		}

		public AIbehaviorDelegateTaskDefinition()
		{
			OnActivate = new();
			OnUpdate = new();
			OnDeactivate = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
