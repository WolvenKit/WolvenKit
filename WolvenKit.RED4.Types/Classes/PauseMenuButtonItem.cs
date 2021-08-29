using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PauseMenuButtonItem : AnimatedListItemController
	{
		private inkTextWidgetReference _fluff;
		private CHandle<inkanimProxy> _animLoop;

		[Ordinal(30)] 
		[RED("Fluff")] 
		public inkTextWidgetReference Fluff
		{
			get => GetProperty(ref _fluff);
			set => SetProperty(ref _fluff, value);
		}

		[Ordinal(31)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get => GetProperty(ref _animLoop);
			set => SetProperty(ref _animLoop, value);
		}
	}
}
