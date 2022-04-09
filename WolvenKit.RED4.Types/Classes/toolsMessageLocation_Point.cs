using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageLocation_Point : toolsIMessageLocation
	{
		[Ordinal(0)] 
		[RED("resourcePath")] 
		public MessageResourcePath ResourcePath
		{
			get => GetPropertyValue<MessageResourcePath>();
			set => SetPropertyValue<MessageResourcePath>(value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector3 Point
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public toolsMessageLocation_Point()
		{
			Point = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
