using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPuppetPreview_ReadyToBeDisplayed : redEvent
	{
		[Ordinal(0)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
