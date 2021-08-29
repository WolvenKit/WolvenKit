using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NarrativePlateGameController : gameuiProjectedHUDGameController
	{
		private inkWidgetReference _plateHolder;
		private CHandle<inkScreenProjection> _projection;
		private CWeakHandle<gameIBlackboard> _narrativePlateBlackboard;
		private CHandle<redCallbackObject> _narrativePlateBlackboardText;
		private CWeakHandle<NarrativePlateLogicController> _logicController;

		[Ordinal(9)] 
		[RED("plateHolder")] 
		public inkWidgetReference PlateHolder
		{
			get => GetProperty(ref _plateHolder);
			set => SetProperty(ref _plateHolder, value);
		}

		[Ordinal(10)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		[Ordinal(11)] 
		[RED("narrativePlateBlackboard")] 
		public CWeakHandle<gameIBlackboard> NarrativePlateBlackboard
		{
			get => GetProperty(ref _narrativePlateBlackboard);
			set => SetProperty(ref _narrativePlateBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("narrativePlateBlackboardText")] 
		public CHandle<redCallbackObject> NarrativePlateBlackboardText
		{
			get => GetProperty(ref _narrativePlateBlackboardText);
			set => SetProperty(ref _narrativePlateBlackboardText, value);
		}

		[Ordinal(13)] 
		[RED("logicController")] 
		public CWeakHandle<NarrativePlateLogicController> LogicController
		{
			get => GetProperty(ref _logicController);
			set => SetProperty(ref _logicController, value);
		}
	}
}
