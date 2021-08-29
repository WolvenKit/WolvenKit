using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TCSTakeOverControlActivate : redEvent
	{
		private CBool _isQuickhack;

		[Ordinal(0)] 
		[RED("IsQuickhack")] 
		public CBool IsQuickhack
		{
			get => GetProperty(ref _isQuickhack);
			set => SetProperty(ref _isQuickhack, value);
		}
	}
}
