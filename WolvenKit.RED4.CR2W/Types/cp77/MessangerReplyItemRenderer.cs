using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessangerReplyItemRenderer : JournalEntryListItemController
	{
		private inkWidgetReference _textRoot;
		private inkWidgetReference _background;
		private CHandle<inkanimProxy> _animSelectionBackground;
		private CHandle<inkanimProxy> _animSelectionText;
		private CBool _selectedState;
		private CFloat _animationDuration;

		[Ordinal(16)] 
		[RED("textRoot")] 
		public inkWidgetReference TextRoot
		{
			get => GetProperty(ref _textRoot);
			set => SetProperty(ref _textRoot, value);
		}

		[Ordinal(17)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(18)] 
		[RED("animSelectionBackground")] 
		public CHandle<inkanimProxy> AnimSelectionBackground
		{
			get => GetProperty(ref _animSelectionBackground);
			set => SetProperty(ref _animSelectionBackground, value);
		}

		[Ordinal(19)] 
		[RED("animSelectionText")] 
		public CHandle<inkanimProxy> AnimSelectionText
		{
			get => GetProperty(ref _animSelectionText);
			set => SetProperty(ref _animSelectionText, value);
		}

		[Ordinal(20)] 
		[RED("selectedState")] 
		public CBool SelectedState
		{
			get => GetProperty(ref _selectedState);
			set => SetProperty(ref _selectedState, value);
		}

		[Ordinal(21)] 
		[RED("animationDuration")] 
		public CFloat AnimationDuration
		{
			get => GetProperty(ref _animationDuration);
			set => SetProperty(ref _animationDuration, value);
		}

		public MessangerReplyItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
