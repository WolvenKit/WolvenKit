using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldLightChannelShapeNode : worldGeometryShapeNode
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
	}
}
