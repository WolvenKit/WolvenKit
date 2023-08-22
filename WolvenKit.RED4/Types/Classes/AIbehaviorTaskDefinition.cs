using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorTaskDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("ignoreTaskCompletion")] 
		public CBool IgnoreTaskCompletion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
