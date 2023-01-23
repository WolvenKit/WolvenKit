using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIThrowGrenadeCommand : AICombatRelatedCommand
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

		[Ordinal(8)] 
		[RED("once")] 
		public CBool Once
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIThrowGrenadeCommand()
		{
			TargetOverridePuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
