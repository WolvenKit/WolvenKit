using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkDisplayContainerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<BasePerkDisplayData> Data
		{
			get => GetPropertyValue<CHandle<BasePerkDisplayData>>();
			set => SetPropertyValue<CHandle<BasePerkDisplayData>>(value);
		}

		[Ordinal(5)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(6)] 
		[RED("controller")] 
		public CWeakHandle<PerkDisplayController> Controller
		{
			get => GetPropertyValue<CWeakHandle<PerkDisplayController>>();
			set => SetPropertyValue<CWeakHandle<PerkDisplayController>>(value);
		}

		public PerkDisplayContainerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
