using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessengerContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("msgPreview")] 
		public inkTextWidgetReference MsgPreview
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("msgCounter")] 
		public inkTextWidgetReference MsgCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("replyAlertIcon")] 
		public inkWidgetReference ReplyAlertIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetPropertyValue<CHandle<ContactData>>();
			set => SetPropertyValue<CHandle<ContactData>>(value);
		}

		[Ordinal(23)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get => GetPropertyValue<CHandle<VirutalNestedListData>>();
			set => SetPropertyValue<CHandle<VirutalNestedListData>>(value);
		}

		[Ordinal(24)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetPropertyValue<CEnum<MessengerContactType>>();
			set => SetPropertyValue<CEnum<MessengerContactType>>(value);
		}

		[Ordinal(25)] 
		[RED("activeItemSync")] 
		public CWeakHandle<MessengerContactSyncData> ActiveItemSync
		{
			get => GetPropertyValue<CWeakHandle<MessengerContactSyncData>>();
			set => SetPropertyValue<CWeakHandle<MessengerContactSyncData>>(value);
		}

		[Ordinal(26)] 
		[RED("isContactActive")] 
		public CBool IsContactActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MessengerContactItemVirtualController()
		{
			Label = new inkTextWidgetReference();
			MsgPreview = new inkTextWidgetReference();
			MsgCounter = new inkTextWidgetReference();
			MsgIndicator = new inkWidgetReference();
			ReplyAlertIcon = new inkWidgetReference();
			CollapseIcon = new inkWidgetReference();
			Image = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
