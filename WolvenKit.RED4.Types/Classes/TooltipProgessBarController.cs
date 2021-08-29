using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipProgessBarController : inkWidgetLogicController
	{
		private inkWidgetReference _progressFill;
		private inkWidgetReference _hintHolder;
		private inkWidgetReference _progressHolder;
		private inkWidgetReference _postprogressHolder;
		private inkCompoundWidgetReference _hintTextHolder;
		private inkWidgetLibraryReference _libraryPath;
		private inkTextWidgetReference _postprogressText;
		private CBool _isCraftable;
		private CBool _isCrafted;

		[Ordinal(1)] 
		[RED("progressFill")] 
		public inkWidgetReference ProgressFill
		{
			get => GetProperty(ref _progressFill);
			set => SetProperty(ref _progressFill, value);
		}

		[Ordinal(2)] 
		[RED("hintHolder")] 
		public inkWidgetReference HintHolder
		{
			get => GetProperty(ref _hintHolder);
			set => SetProperty(ref _hintHolder, value);
		}

		[Ordinal(3)] 
		[RED("progressHolder")] 
		public inkWidgetReference ProgressHolder
		{
			get => GetProperty(ref _progressHolder);
			set => SetProperty(ref _progressHolder, value);
		}

		[Ordinal(4)] 
		[RED("postprogressHolder")] 
		public inkWidgetReference PostprogressHolder
		{
			get => GetProperty(ref _postprogressHolder);
			set => SetProperty(ref _postprogressHolder, value);
		}

		[Ordinal(5)] 
		[RED("hintTextHolder")] 
		public inkCompoundWidgetReference HintTextHolder
		{
			get => GetProperty(ref _hintTextHolder);
			set => SetProperty(ref _hintTextHolder, value);
		}

		[Ordinal(6)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(7)] 
		[RED("postprogressText")] 
		public inkTextWidgetReference PostprogressText
		{
			get => GetProperty(ref _postprogressText);
			set => SetProperty(ref _postprogressText, value);
		}

		[Ordinal(8)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetProperty(ref _isCraftable);
			set => SetProperty(ref _isCraftable, value);
		}

		[Ordinal(9)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get => GetProperty(ref _isCrafted);
			set => SetProperty(ref _isCrafted, value);
		}
	}
}
