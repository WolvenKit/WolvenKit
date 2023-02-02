using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIInjectCombatTargetCommand : AICombatRelatedCommand
	{
		[Ordinal(5)] 
		[RED("targetNodeRef")] 
		public NodeRef TargetNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(6)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIInjectCombatTargetCommand()
		{
			TargetPuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
