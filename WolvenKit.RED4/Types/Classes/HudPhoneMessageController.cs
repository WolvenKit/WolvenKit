using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HudPhoneMessageController : HUDPhoneElement
	{
		[Ordinal(2)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("MessageAnim")] 
		public CHandle<inkanimProxy> MessageAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(4)] 
		[RED("ShowingAnimationName")] 
		public CName ShowingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("HidingAnimationName")] 
		public CName HidingAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("VisibleAnimationName")] 
		public CName VisibleAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("MessageMaxLength")] 
		public CInt32 MessageMaxLength
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("MessageTopper")] 
		public CString MessageTopper
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("Paused")] 
		public CBool Paused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("CurrentMessage")] 
		public CWeakHandle<gameJournalPhoneMessage> CurrentMessage
		{
			get => GetPropertyValue<CWeakHandle<gameJournalPhoneMessage>>();
			set => SetPropertyValue<CWeakHandle<gameJournalPhoneMessage>>(value);
		}

		[Ordinal(11)] 
		[RED("Queue")] 
		public CArray<CWeakHandle<gameJournalPhoneMessage>> Queue
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalPhoneMessage>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalPhoneMessage>>>(value);
		}

		public HudPhoneMessageController()
		{
			MessageText = new();
			ShowingAnimationName = "messageShowingAnimation";
			HidingAnimationName = "messageHidingAnimation";
			VisibleAnimationName = "messageVisibleAnimation";
			MessageMaxLength = 120;
			MessageTopper = "...";
			Queue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
