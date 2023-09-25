using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipAttachmentGroupController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("indicatorContainer")] 
		public inkWidgetReference IndicatorContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("indicatorWidget")] 
		public inkWidgetReference IndicatorWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("rarityContainer")] 
		public inkWidgetReference RarityContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rarityWidget")] 
		public inkImageWidgetReference RarityWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("entriesContainer")] 
		public inkCompoundWidgetReference EntriesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("entriesControllers")] 
		public CArray<CWeakHandle<NewItemTooltipAttachmentEntryController>> EntriesControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<NewItemTooltipAttachmentEntryController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NewItemTooltipAttachmentEntryController>>>(value);
		}

		[Ordinal(7)] 
		[RED("entriesData")] 
		public CArray<CHandle<NewItemTooltipAttachmentEntryData>> EntriesData
		{
			get => GetPropertyValue<CArray<CHandle<NewItemTooltipAttachmentEntryData>>>();
			set => SetPropertyValue<CArray<CHandle<NewItemTooltipAttachmentEntryData>>>(value);
		}

		[Ordinal(8)] 
		[RED("requestedEntries")] 
		public CInt32 RequestedEntries
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("colorState")] 
		public CName ColorState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public NewItemTooltipAttachmentGroupController()
		{
			IndicatorContainer = new inkWidgetReference();
			IndicatorWidget = new inkWidgetReference();
			RarityContainer = new inkWidgetReference();
			RarityWidget = new inkImageWidgetReference();
			EntriesContainer = new inkCompoundWidgetReference();
			EntriesControllers = new();
			EntriesData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
