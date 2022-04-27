using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneContactItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("msgCount")] 
		public inkTextWidgetReference MsgCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("questFlag")] 
		public inkWidgetReference QuestFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("regFlag")] 
		public inkWidgetReference RegFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("animProxyQuest")] 
		public CHandle<inkanimProxy> AnimProxyQuest
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("animProxySelection")] 
		public CHandle<inkanimProxy> AnimProxySelection
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get => GetPropertyValue<CHandle<ContactData>>();
			set => SetPropertyValue<CHandle<ContactData>>(value);
		}

		public PhoneContactItemVirtualController()
		{
			Label = new();
			MsgCount = new();
			MsgIndicator = new();
			QuestFlag = new();
			RegFlag = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
