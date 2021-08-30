using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGameNotificationData : inkUserData
	{
		private CName _notificationName;
		private CBool _isBlocking;
		private CBool _useCursor;
		private CName _queueName;
		private CName _introAnimation;
		private CWeakHandle<inkGameNotificationToken> _token;

		[Ordinal(0)] 
		[RED("notificationName")] 
		public CName NotificationName
		{
			get => GetProperty(ref _notificationName);
			set => SetProperty(ref _notificationName, value);
		}

		[Ordinal(1)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetProperty(ref _isBlocking);
			set => SetProperty(ref _isBlocking, value);
		}

		[Ordinal(2)] 
		[RED("useCursor")] 
		public CBool UseCursor
		{
			get => GetProperty(ref _useCursor);
			set => SetProperty(ref _useCursor, value);
		}

		[Ordinal(3)] 
		[RED("queueName")] 
		public CName QueueName
		{
			get => GetProperty(ref _queueName);
			set => SetProperty(ref _queueName, value);
		}

		[Ordinal(4)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(5)] 
		[RED("token")] 
		public CWeakHandle<inkGameNotificationToken> Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}

		public inkGameNotificationData()
		{
			_queueName = "Default";
			_introAnimation = "__preload__";
		}
	}
}
