using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class LeftHandCyberwareActionAbstractEvents : LeftHandCyberwareEventsTransition
	{
		[Ordinal(0)] 
		[RED("projectileReleased")] 
		public CBool ProjectileReleased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LeftHandCyberwareActionAbstractEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
