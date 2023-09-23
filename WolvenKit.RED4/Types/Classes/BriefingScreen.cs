using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BriefingScreen : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("logicControllerRef")] 
		public inkWidgetReference LogicControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(11)] 
		[RED("bbOpenerEventID")] 
		public CHandle<redCallbackObject> BbOpenerEventID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("bbSizeEventID")] 
		public CHandle<redCallbackObject> BbSizeEventID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("bbAlignmentEventID")] 
		public CHandle<redCallbackObject> BbAlignmentEventID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public BriefingScreen()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
