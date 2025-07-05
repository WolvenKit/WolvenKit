using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorPassiveConditionDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorPassiveConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
