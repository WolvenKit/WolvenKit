using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleSprintHarassCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("result")] 
		public CBool Result
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SimpleSprintHarassCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
