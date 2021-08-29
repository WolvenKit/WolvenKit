using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiNewsFeedDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _newsTitleWidget;
		private CName _randomNewsLibraryWidget;
		private inkCompoundWidgetReference _randomNewsContainer;

		[Ordinal(1)] 
		[RED("newsTitleWidget")] 
		public inkTextWidgetReference NewsTitleWidget
		{
			get => GetProperty(ref _newsTitleWidget);
			set => SetProperty(ref _newsTitleWidget, value);
		}

		[Ordinal(2)] 
		[RED("randomNewsLibraryWidget")] 
		public CName RandomNewsLibraryWidget
		{
			get => GetProperty(ref _randomNewsLibraryWidget);
			set => SetProperty(ref _randomNewsLibraryWidget, value);
		}

		[Ordinal(3)] 
		[RED("randomNewsContainer")] 
		public inkCompoundWidgetReference RandomNewsContainer
		{
			get => GetProperty(ref _randomNewsContainer);
			set => SetProperty(ref _randomNewsContainer, value);
		}
	}
}
