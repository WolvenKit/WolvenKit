using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("counter")] 
		public inkTextWidgetReference Counter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("isNewFlag")] 
		public inkWidgetReference IsNewFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("entryData")] 
		public CHandle<ShardEntryData> EntryData
		{
			get => GetPropertyValue<CHandle<ShardEntryData>>();
			set => SetPropertyValue<CHandle<ShardEntryData>>(value);
		}

		[Ordinal(20)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get => GetPropertyValue<CHandle<VirutalNestedListData>>();
			set => SetPropertyValue<CHandle<VirutalNestedListData>>(value);
		}

		[Ordinal(21)] 
		[RED("activeItemSync")] 
		public CWeakHandle<CodexListSyncData> ActiveItemSync
		{
			get => GetPropertyValue<CWeakHandle<CodexListSyncData>>();
			set => SetPropertyValue<CWeakHandle<CodexListSyncData>>(value);
		}

		[Ordinal(22)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ShardItemVirtualController()
		{
			Label = new inkTextWidgetReference();
			Counter = new inkTextWidgetReference();
			CollapseIcon = new inkWidgetReference();
			IsNewFlag = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
