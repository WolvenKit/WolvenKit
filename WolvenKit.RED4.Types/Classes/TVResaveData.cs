using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TVResaveData : RedBaseClass
	{
		private MediaResaveData _mediaResaveData;
		private CArray<STvChannel> _channels;
		private CName _securedText;
		private CBool _muteInterface;
		private CBool _useWhiteNoiseFX;

		[Ordinal(0)] 
		[RED("mediaResaveData")] 
		public MediaResaveData MediaResaveData
		{
			get => GetProperty(ref _mediaResaveData);
			set => SetProperty(ref _mediaResaveData, value);
		}

		[Ordinal(1)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get => GetProperty(ref _channels);
			set => SetProperty(ref _channels, value);
		}

		[Ordinal(2)] 
		[RED("securedText")] 
		public CName SecuredText
		{
			get => GetProperty(ref _securedText);
			set => SetProperty(ref _securedText, value);
		}

		[Ordinal(3)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get => GetProperty(ref _muteInterface);
			set => SetProperty(ref _muteInterface, value);
		}

		[Ordinal(4)] 
		[RED("useWhiteNoiseFX")] 
		public CBool UseWhiteNoiseFX
		{
			get => GetProperty(ref _useWhiteNoiseFX);
			set => SetProperty(ref _useWhiteNoiseFX, value);
		}
	}
}
