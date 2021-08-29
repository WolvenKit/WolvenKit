using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivateCoverEvents : CoverActionEventsTransition
	{
		private CBool _usingCover;

		[Ordinal(3)] 
		[RED("usingCover")] 
		public CBool UsingCover
		{
			get => GetProperty(ref _usingCover);
			set => SetProperty(ref _usingCover, value);
		}
	}
}
