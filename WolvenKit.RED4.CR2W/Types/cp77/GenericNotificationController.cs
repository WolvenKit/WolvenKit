using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericNotificationController : gameuiGenericNotificationReceiverGameController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _textRef;
		private inkTextWidgetReference _actionLabelRef;
		private inkWidgetReference _actionRef;
		private CBool _blockAction;
		private CHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CHandle<gameuiGenericNotificationViewData> _data;
		private wCHandle<gameObject> _player;
		private CBool _isInteractive;

		[Ordinal(3)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetProperty(ref _titleRef);
			set => SetProperty(ref _titleRef, value);
		}

		[Ordinal(4)] 
		[RED("textRef")] 
		public inkTextWidgetReference TextRef
		{
			get => GetProperty(ref _textRef);
			set => SetProperty(ref _textRef, value);
		}

		[Ordinal(5)] 
		[RED("actionLabelRef")] 
		public inkTextWidgetReference ActionLabelRef
		{
			get => GetProperty(ref _actionLabelRef);
			set => SetProperty(ref _actionLabelRef, value);
		}

		[Ordinal(6)] 
		[RED("actionRef")] 
		public inkWidgetReference ActionRef
		{
			get => GetProperty(ref _actionRef);
			set => SetProperty(ref _actionRef, value);
		}

		[Ordinal(7)] 
		[RED("blockAction")] 
		public CBool BlockAction
		{
			get => GetProperty(ref _blockAction);
			set => SetProperty(ref _blockAction, value);
		}

		[Ordinal(8)] 
		[RED("translationAnimationCtrl")] 
		public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<gameuiGenericNotificationViewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(11)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		public GenericNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
