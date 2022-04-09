using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIApproachingAreaEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("isApproachCancellation")] 
		public CBool IsApproachCancellation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("areaComponent")] 
		public CWeakHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get => GetPropertyValue<CWeakHandle<gameStaticAreaShapeComponent>>();
			set => SetPropertyValue<CWeakHandle<gameStaticAreaShapeComponent>>(value);
		}

		[Ordinal(4)] 
		[RED("responseTarget")] 
		public CWeakHandle<entEntity> ResponseTarget
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public AIApproachingAreaEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
