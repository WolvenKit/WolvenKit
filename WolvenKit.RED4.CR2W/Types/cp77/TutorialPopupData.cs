using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialPopupData : inkGameNotificationData
	{
		private CBool _closeAtInput;
		private CBool _pauseGame;
		private CBool _isModal;
		private CEnum<gamePopupPosition> _position;
		private inkMargin _margin;
		private TweakDBID _imageId;
		private CString _title;
		private CString _message;
		private CEnum<gameVideoType> _videoType;
		private redResourceReferenceScriptToken _video;

		[Ordinal(6)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetProperty(ref _closeAtInput);
			set => SetProperty(ref _closeAtInput, value);
		}

		[Ordinal(7)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetProperty(ref _pauseGame);
			set => SetProperty(ref _pauseGame, value);
		}

		[Ordinal(8)] 
		[RED("isModal")] 
		public CBool IsModal
		{
			get => GetProperty(ref _isModal);
			set => SetProperty(ref _isModal, value);
		}

		[Ordinal(9)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(10)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(11)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		[Ordinal(12)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(13)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(14)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetProperty(ref _videoType);
			set => SetProperty(ref _videoType, value);
		}

		[Ordinal(15)] 
		[RED("video")] 
		public redResourceReferenceScriptToken Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		public TutorialPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
