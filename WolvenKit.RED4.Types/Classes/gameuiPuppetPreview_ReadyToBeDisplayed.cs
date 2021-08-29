using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPuppetPreview_ReadyToBeDisplayed : redEvent
	{
		private CBool _isMale;

		[Ordinal(0)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetProperty(ref _isMale);
			set => SetProperty(ref _isMale, value);
		}
	}
}
