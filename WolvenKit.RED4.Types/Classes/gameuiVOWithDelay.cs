using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiVOWithDelay : RedBaseClass
	{
		private CFloat _playDelay;
		private CString _voHexID;

		[Ordinal(0)] 
		[RED("playDelay")] 
		public CFloat PlayDelay
		{
			get => GetProperty(ref _playDelay);
			set => SetProperty(ref _playDelay, value);
		}

		[Ordinal(1)] 
		[RED("voHexID")] 
		public CString VoHexID
		{
			get => GetProperty(ref _voHexID);
			set => SetProperty(ref _voHexID, value);
		}
	}
}
