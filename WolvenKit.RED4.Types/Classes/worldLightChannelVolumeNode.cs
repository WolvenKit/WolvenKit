using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldLightChannelVolumeNode : worldAreaShapeNode
	{
		private CEnum<rendLightChannel> _channels;
		private CFloat _streamingDistanceFactor;

		[Ordinal(6)] 
		[RED("channels")] 
		public CEnum<rendLightChannel> Channels
		{
			get => GetProperty(ref _channels);
			set => SetProperty(ref _channels, value);
		}

		[Ordinal(7)] 
		[RED("streamingDistanceFactor")] 
		public CFloat StreamingDistanceFactor
		{
			get => GetProperty(ref _streamingDistanceFactor);
			set => SetProperty(ref _streamingDistanceFactor, value);
		}

		public worldLightChannelVolumeNode()
		{
			_channels = new() { Value = Enums.rendLightChannel.LC_Channel1 };
			_streamingDistanceFactor = 5.000000F;
		}
	}
}
