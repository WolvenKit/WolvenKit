using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class activityLogEntryLogicController : inkWidgetLogicController
	{
		private CBool _available;
		private CUInt16 _originalSize;
		private CUInt16 _size;
		private CString _displayText;
		private CWeakHandle<inkTextWidget> _root;
		private CHandle<inkanimController> _appearingAnim;
		private CHandle<inkanimController> _typingAnim;
		private CHandle<inkanimController> _disappearingAnim;
		private CHandle<inkanimDefinition> _typingAnimDef;
		private CHandle<inkanimProxy> _typingAnimProxy;
		private CHandle<inkanimDefinition> _disappearingAnimDef;
		private CHandle<inkanimProxy> _disappearingAnimProxy;

		[Ordinal(1)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetProperty(ref _available);
			set => SetProperty(ref _available, value);
		}

		[Ordinal(2)] 
		[RED("originalSize")] 
		public CUInt16 OriginalSize
		{
			get => GetProperty(ref _originalSize);
			set => SetProperty(ref _originalSize, value);
		}

		[Ordinal(3)] 
		[RED("size")] 
		public CUInt16 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(4)] 
		[RED("displayText")] 
		public CString DisplayText
		{
			get => GetProperty(ref _displayText);
			set => SetProperty(ref _displayText, value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CWeakHandle<inkTextWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("appearingAnim")] 
		public CHandle<inkanimController> AppearingAnim
		{
			get => GetProperty(ref _appearingAnim);
			set => SetProperty(ref _appearingAnim, value);
		}

		[Ordinal(7)] 
		[RED("typingAnim")] 
		public CHandle<inkanimController> TypingAnim
		{
			get => GetProperty(ref _typingAnim);
			set => SetProperty(ref _typingAnim, value);
		}

		[Ordinal(8)] 
		[RED("disappearingAnim")] 
		public CHandle<inkanimController> DisappearingAnim
		{
			get => GetProperty(ref _disappearingAnim);
			set => SetProperty(ref _disappearingAnim, value);
		}

		[Ordinal(9)] 
		[RED("typingAnimDef")] 
		public CHandle<inkanimDefinition> TypingAnimDef
		{
			get => GetProperty(ref _typingAnimDef);
			set => SetProperty(ref _typingAnimDef, value);
		}

		[Ordinal(10)] 
		[RED("typingAnimProxy")] 
		public CHandle<inkanimProxy> TypingAnimProxy
		{
			get => GetProperty(ref _typingAnimProxy);
			set => SetProperty(ref _typingAnimProxy, value);
		}

		[Ordinal(11)] 
		[RED("disappearingAnimDef")] 
		public CHandle<inkanimDefinition> DisappearingAnimDef
		{
			get => GetProperty(ref _disappearingAnimDef);
			set => SetProperty(ref _disappearingAnimDef, value);
		}

		[Ordinal(12)] 
		[RED("disappearingAnimProxy")] 
		public CHandle<inkanimProxy> DisappearingAnimProxy
		{
			get => GetProperty(ref _disappearingAnimProxy);
			set => SetProperty(ref _disappearingAnimProxy, value);
		}
	}
}
