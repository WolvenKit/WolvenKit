using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerLevel : ScannerChunk
	{
		private CInt32 _level;
		private CBool _isHard;

		[Ordinal(0)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(1)] 
		[RED("isHard")] 
		public CBool IsHard
		{
			get => GetProperty(ref _isHard);
			set => SetProperty(ref _isHard, value);
		}
	}
}
