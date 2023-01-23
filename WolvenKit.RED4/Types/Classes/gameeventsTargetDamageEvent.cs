using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsTargetDamageEvent : gameeventsTargetHitEvent
	{
		[Ordinal(12)] 
		[RED("damage")] 
		public CFloat Damage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameeventsTargetDamageEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
