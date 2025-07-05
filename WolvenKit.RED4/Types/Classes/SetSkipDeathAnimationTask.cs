using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetSkipDeathAnimationTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetSkipDeathAnimationTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
