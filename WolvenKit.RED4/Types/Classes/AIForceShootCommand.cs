using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIForceShootCommand : AICombatRelatedCommand
	{
		[Ordinal(5)] 
		[RED("targetOverrideNodeRef")] 
		public NodeRef TargetOverrideNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(6)] 
		[RED("targetOverridePuppetRef")] 
		public gameEntityReference TargetOverridePuppetRef
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

		public AIForceShootCommand()
		{
			TargetOverridePuppetRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
