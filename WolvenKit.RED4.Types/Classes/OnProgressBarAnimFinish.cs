using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnProgressBarAnimFinish : redEvent
	{
		private CFloat _fullbarSize;
		private CBool _isNegative;

		[Ordinal(0)] 
		[RED("FullbarSize")] 
		public CFloat FullbarSize
		{
			get => GetProperty(ref _fullbarSize);
			set => SetProperty(ref _fullbarSize, value);
		}

		[Ordinal(1)] 
		[RED("IsNegative")] 
		public CBool IsNegative
		{
			get => GetProperty(ref _isNegative);
			set => SetProperty(ref _isNegative, value);
		}
	}
}
