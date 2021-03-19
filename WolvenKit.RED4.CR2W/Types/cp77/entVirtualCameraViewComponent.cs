using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVirtualCameraViewComponent : entIVisualComponent
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

		public entVirtualCameraViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
