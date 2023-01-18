using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimationsLoadedTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("coreAnims")] 
		public CBool CoreAnims
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("setSignal")] 
		public CBool SetSignal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("melee")] 
		public CBool Melee
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimationsLoadedTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
