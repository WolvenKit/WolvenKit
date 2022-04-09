using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationBodyMorphImageThumbnail : inkButtonAnimatedController
	{
		[Ordinal(22)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("equipped")] 
		public inkWidgetReference Equipped
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public characterCreationBodyMorphImageThumbnail()
		{
			Selector = new();
			Equipped = new();
			Bg = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
