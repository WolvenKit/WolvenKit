using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldLightChannelShapeNode : worldGeometryShapeNode
	{
		[Ordinal(4)] 
		[RED("channels")] 
		public CBitField<rendLightChannel> Channels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(5)] 
		[RED("streamingDistanceFactor")] 
		public CFloat StreamingDistanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldLightChannelShapeNode()
		{
			Color = new CColor { Red = 133, Green = 191, Blue = 255, Alpha = 64 };
			Channels = Enums.rendLightChannel.LC_Channel1;
			StreamingDistanceFactor = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
