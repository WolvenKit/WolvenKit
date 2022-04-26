using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGameNotificationData : inkUserData
	{
		[Ordinal(0)] 
		[RED("notificationName")] 
		public CName NotificationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("requiredGameState")] 
		public CName RequiredGameState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("useCursor")] 
		public CBool UseCursor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("queueName")] 
		public CName QueueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("token")] 
		public CWeakHandle<inkGameNotificationToken> Token
		{
			get => GetPropertyValue<CWeakHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CWeakHandle<inkGameNotificationToken>>(value);
		}

		public inkGameNotificationData()
		{
			QueueName = "Default";
			IntroAnimation = "__preload__";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
