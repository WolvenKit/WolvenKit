using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHUDVideoStopEvent : RedBaseClass
	{
		private CUInt64 _videoPathHash;
		private CBool _isSkip;

		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get => GetProperty(ref _videoPathHash);
			set => SetProperty(ref _videoPathHash, value);
		}

		[Ordinal(1)] 
		[RED("isSkip")] 
		public CBool IsSkip
		{
			get => GetProperty(ref _isSkip);
			set => SetProperty(ref _isSkip, value);
		}
	}
}
