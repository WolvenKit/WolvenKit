using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageLocation_BoundingBox : toolsIMessageLocation
	{
		[Ordinal(0)] 
		[RED("resourcePath")] 
		public MessageResourcePath ResourcePath
		{
			get => GetPropertyValue<MessageResourcePath>();
			set => SetPropertyValue<MessageResourcePath>(value);
		}

		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public toolsMessageLocation_BoundingBox()
		{
			Box = new() { Min = new(), Max = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
