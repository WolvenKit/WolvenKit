using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVirtualCameraViewComponent : entIVisualComponent
	{
		private CName _virtualCameraName;
		private Vector2 _targetPlaneSize;

		[Ordinal(8)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get => GetProperty(ref _virtualCameraName);
			set => SetProperty(ref _virtualCameraName, value);
		}

		[Ordinal(9)] 
		[RED("targetPlaneSize")] 
		public Vector2 TargetPlaneSize
		{
			get => GetProperty(ref _targetPlaneSize);
			set => SetProperty(ref _targetPlaneSize, value);
		}
	}
}
