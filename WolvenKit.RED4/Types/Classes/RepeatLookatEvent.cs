using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RepeatLookatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<entEntity> Target
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public RepeatLookatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
