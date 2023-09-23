using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleMessengerItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("msgPreview")] 
		public inkTextWidgetReference MsgPreview
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("replyAlertIcon")] 
		public inkWidgetReference ReplyAlertIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetPropertyValue<CEnum<MessengerContactType>>();
			set => SetPropertyValue<CEnum<MessengerContactType>>(value);
		}

		[Ordinal(25)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetPropertyValue<CHandle<ContactData>>();
			set => SetPropertyValue<CHandle<ContactData>>(value);
		}

		[Ordinal(26)] 
		[RED("activeItemSync")] 
		public CWeakHandle<MessengerContactSyncData> ActiveItemSync
		{
			get => GetPropertyValue<CWeakHandle<MessengerContactSyncData>>();
			set => SetPropertyValue<CWeakHandle<MessengerContactSyncData>>(value);
		}

		[Ordinal(27)] 
		[RED("isContactActive")] 
		public CBool IsContactActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SimpleMessengerItemVirtualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
