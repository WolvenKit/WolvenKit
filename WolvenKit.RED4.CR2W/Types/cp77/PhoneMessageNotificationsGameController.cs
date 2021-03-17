using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessageNotificationsGameController : gameuiWidgetGameController
	{
		private CInt32 _maxMessageSize;
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _text;
		private inkTextWidgetReference _actionText;
		private CHandle<inkWidget> _actionPanel;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<JournalNotificationData> _data;

		[Ordinal(2)] 
		[RED("maxMessageSize")] 
		public CInt32 MaxMessageSize
		{
			get => GetProperty(ref _maxMessageSize);
			set => SetProperty(ref _maxMessageSize, value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(4)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(5)] 
		[RED("actionText")] 
		public inkTextWidgetReference ActionText
		{
			get => GetProperty(ref _actionText);
			set => SetProperty(ref _actionText, value);
		}

		[Ordinal(6)] 
		[RED("actionPanel")] 
		public CHandle<inkWidget> ActionPanel
		{
			get => GetProperty(ref _actionPanel);
			set => SetProperty(ref _actionPanel, value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(8)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public wCHandle<JournalNotificationData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public PhoneMessageNotificationsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
