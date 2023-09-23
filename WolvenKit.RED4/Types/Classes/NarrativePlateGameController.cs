using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NarrativePlateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("plateHolder")] 
		public inkWidgetReference PlateHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(11)] 
		[RED("narrativePlateBlackboard")] 
		public CWeakHandle<gameIBlackboard> NarrativePlateBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("narrativePlateBlackboardText")] 
		public CHandle<redCallbackObject> NarrativePlateBlackboardText
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("logicController")] 
		public CWeakHandle<NarrativePlateLogicController> LogicController
		{
			get => GetPropertyValue<CWeakHandle<NarrativePlateLogicController>>();
			set => SetPropertyValue<CWeakHandle<NarrativePlateLogicController>>(value);
		}

		public NarrativePlateGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
