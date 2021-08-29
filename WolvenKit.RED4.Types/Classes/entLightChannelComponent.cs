using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entLightChannelComponent : entIVisualComponent
	{
		private CBool _isEnabled;
		private CEnum<rendLightChannel> _channels;
		private CHandle<GeometryShape> _shape;

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(9)] 
		[RED("channels")] 
		public CEnum<rendLightChannel> Channels
		{
			get => GetProperty(ref _channels);
			set => SetProperty(ref _channels, value);
		}

		[Ordinal(10)] 
		[RED("shape")] 
		public CHandle<GeometryShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}
	}
}
