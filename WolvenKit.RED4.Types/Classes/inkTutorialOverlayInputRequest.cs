using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTutorialOverlayInputRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("isInputRequested")] 
		public CBool IsInputRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
