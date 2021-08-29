using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetGlobalTvOnly : redEvent
	{
		private CBool _isGlobalTvOnly;

		[Ordinal(0)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get => GetProperty(ref _isGlobalTvOnly);
			set => SetProperty(ref _isGlobalTvOnly, value);
		}
	}
}
