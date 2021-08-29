using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsMessageLocation_Point : toolsIMessageLocation
	{
		private MessageResourcePath _resourcePath;
		private Vector3 _point;

		[Ordinal(0)] 
		[RED("resourcePath")] 
		public MessageResourcePath ResourcePath
		{
			get => GetProperty(ref _resourcePath);
			set => SetProperty(ref _resourcePath, value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector3 Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}
	}
}
