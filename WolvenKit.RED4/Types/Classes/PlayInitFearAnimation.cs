using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayInitFearAnimation : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("grenadePanic")] 
		public CBool GrenadePanic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayInitFearAnimation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
