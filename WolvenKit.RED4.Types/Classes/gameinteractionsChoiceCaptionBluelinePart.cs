using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceCaptionBluelinePart : gameinteractionsChoiceCaptionPart
	{
		private CHandle<gameinteractionsvisBluelineDescription> _blueline;

		[Ordinal(0)] 
		[RED("blueline")] 
		public CHandle<gameinteractionsvisBluelineDescription> Blueline
		{
			get => GetProperty(ref _blueline);
			set => SetProperty(ref _blueline, value);
		}
	}
}
