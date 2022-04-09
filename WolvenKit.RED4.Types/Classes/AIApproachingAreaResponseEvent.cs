using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIApproachingAreaResponseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sender")] 
		public CWeakHandle<entEntity> Sender
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("areaComponent")] 
		public CWeakHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get => GetPropertyValue<CWeakHandle<gameStaticAreaShapeComponent>>();
			set => SetPropertyValue<CWeakHandle<gameStaticAreaShapeComponent>>(value);
		}

		[Ordinal(2)] 
		[RED("isPassingThrough")] 
		public CBool IsPassingThrough
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIApproachingAreaResponseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
