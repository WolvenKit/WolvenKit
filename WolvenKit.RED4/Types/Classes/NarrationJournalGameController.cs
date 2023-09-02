using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NarrationJournalGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("entriesContainer")] 
		public inkCompoundWidgetReference EntriesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("narrationJournalBlackboardId")] 
		public CHandle<redCallbackObject> NarrationJournalBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public NarrationJournalGameController()
		{
			EntriesContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
