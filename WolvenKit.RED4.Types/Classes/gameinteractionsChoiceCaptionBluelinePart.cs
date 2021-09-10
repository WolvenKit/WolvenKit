using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceCaptionBluelinePart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)] 
		[RED("blueline")] 
		public CHandle<gameinteractionsvisBluelineDescription> Blueline
		{
			get => GetPropertyValue<CHandle<gameinteractionsvisBluelineDescription>>();
			set => SetPropertyValue<CHandle<gameinteractionsvisBluelineDescription>>(value);
		}
	}
}
