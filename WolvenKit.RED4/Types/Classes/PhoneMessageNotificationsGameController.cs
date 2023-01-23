using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneMessageNotificationsGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("maxMessageSize")] 
		public CInt32 MaxMessageSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("actionText")] 
		public inkTextWidgetReference ActionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("actionPanel")] 
		public CWeakHandle<inkWidget> ActionPanel
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(8)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CWeakHandle<JournalNotificationData> Data
		{
			get => GetPropertyValue<CWeakHandle<JournalNotificationData>>();
			set => SetPropertyValue<CWeakHandle<JournalNotificationData>>(value);
		}

		public PhoneMessageNotificationsGameController()
		{
			MaxMessageSize = 60;
			Title = new();
			Text = new();
			ActionText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
