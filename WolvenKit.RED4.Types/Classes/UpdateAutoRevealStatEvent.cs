using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateAutoRevealStatEvent : redEvent
	{
		private CBool _hasAutoReveal;

		[Ordinal(0)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetProperty(ref _hasAutoReveal);
			set => SetProperty(ref _hasAutoReveal, value);
		}
	}
}
