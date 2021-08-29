using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickhackModule : HUDModule
	{
		private CBool _calculateClose;

		[Ordinal(3)] 
		[RED("calculateClose")] 
		public CBool CalculateClose
		{
			get => GetProperty(ref _calculateClose);
			set => SetProperty(ref _calculateClose, value);
		}
	}
}
