using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldLightChannelVolumeNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("channels")] 
		public CBitField<rendLightChannel> Channels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(7)] 
		[RED("streamingDistanceFactor")] 
		public CFloat StreamingDistanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldLightChannelVolumeNode()
		{
			Channels = Enums.rendLightChannel.LC_Channel1;
			StreamingDistanceFactor = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
