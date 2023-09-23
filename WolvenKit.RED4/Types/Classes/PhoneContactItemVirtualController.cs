using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("preview")] 
		public inkTextWidgetReference Preview
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("msgCount")] 
		public inkTextWidgetReference MsgCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("questFlag")] 
		public inkWidgetReference QuestFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("regFlag")] 
		public inkWidgetReference RegFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("replyAlertIcon")] 
		public inkWidgetReference ReplyAlertIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("callInputHint")] 
		public inkWidgetReference CallInputHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("chatInputHint")] 
		public inkWidgetReference ChatInputHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("separtor")] 
		public inkWidgetReference Separtor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("animProxySelection")] 
		public CHandle<inkanimProxy> AnimProxySelection
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("animProxyHide")] 
		public CHandle<inkanimProxy> AnimProxyHide
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(30)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetPropertyValue<CHandle<ContactData>>();
			set => SetPropertyValue<CHandle<ContactData>>(value);
		}

		[Ordinal(31)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(32)] 
		[RED("isQuestImportant")] 
		public CBool IsQuestImportant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("isUnread")] 
		public CBool IsUnread
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isCallingEnabled")] 
		public CBool IsCallingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public PhoneContactItemVirtualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
