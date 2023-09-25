using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BrowserGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("logicControllerRef")] 
		public inkWidgetReference LogicControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(4)] 
		[RED("locationTags")] 
		public CArray<CName> LocationTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public BrowserGameController()
		{
			LogicControllerRef = new inkWidgetReference();
			LocationTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
