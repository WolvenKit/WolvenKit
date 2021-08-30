using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TV : InteractiveDevice
	{
		private CArray<STvChannel> _channels;
		private CInt32 _initialActiveChannel;
		private CString _securedText;
		private CBool _isInteractive;
		private CBool _muteInterface;
		private CBool _useWhiteNoiseFX;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CBool _isTVMoving;

		[Ordinal(97)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get => GetProperty(ref _channels);
			set => SetProperty(ref _channels, value);
		}

		[Ordinal(98)] 
		[RED("initialActiveChannel")] 
		public CInt32 InitialActiveChannel
		{
			get => GetProperty(ref _initialActiveChannel);
			set => SetProperty(ref _initialActiveChannel, value);
		}

		[Ordinal(99)] 
		[RED("securedText")] 
		public CString SecuredText
		{
			get => GetProperty(ref _securedText);
			set => SetProperty(ref _securedText, value);
		}

		[Ordinal(100)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(101)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get => GetProperty(ref _muteInterface);
			set => SetProperty(ref _muteInterface, value);
		}

		[Ordinal(102)] 
		[RED("useWhiteNoiseFX")] 
		public CBool UseWhiteNoiseFX
		{
			get => GetProperty(ref _useWhiteNoiseFX);
			set => SetProperty(ref _useWhiteNoiseFX, value);
		}

		[Ordinal(103)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(104)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(105)] 
		[RED("isTVMoving")] 
		public CBool IsTVMoving
		{
			get => GetProperty(ref _isTVMoving);
			set => SetProperty(ref _isTVMoving, value);
		}

		public TV()
		{
			_securedText = new() { Text = "SECURED" };
			_muteInterface = true;
		}
	}
}
