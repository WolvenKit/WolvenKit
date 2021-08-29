using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBountyAwardedEvent : redEvent
	{
		private CBool _awarded;

		[Ordinal(0)] 
		[RED("awarded")] 
		public CBool Awarded
		{
			get => GetProperty(ref _awarded);
			set => SetProperty(ref _awarded, value);
		}
	}
}
