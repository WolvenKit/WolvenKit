using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLightChannelComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("channels")] 
		public CBitField<rendLightChannel> Channels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		[Ordinal(10)] 
		[RED("shape")] 
		public CHandle<GeometryShape> Shape
		{
			get => GetPropertyValue<CHandle<GeometryShape>>();
			set => SetPropertyValue<CHandle<GeometryShape>>(value);
		}

		public entLightChannelComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			IsEnabled = true;
			Channels = Enums.rendLightChannel.LC_Channel1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
