using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTutorialOverlayInputRequest : redEvent
	{
		private CBool _isInputRequested;

		[Ordinal(0)] 
		[RED("isInputRequested")] 
		public CBool IsInputRequested
		{
			get => GetProperty(ref _isInputRequested);
			set => SetProperty(ref _isInputRequested, value);
		}
	}
}
