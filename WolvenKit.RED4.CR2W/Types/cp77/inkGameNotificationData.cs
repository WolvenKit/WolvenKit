using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameNotificationData : inkUserData
	{
		private CName _notificationName;
		private CBool _isBlocking;
		private CBool _useCursor;
		private CName _queueName;
		private CName _introAnimation;
		private wCHandle<inkGameNotificationToken> _token;

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
		public wCHandle<inkGameNotificationToken> Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}

		public inkGameNotificationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
