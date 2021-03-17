using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraPlacementEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private Transform _cameraTransformLS;

		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetProperty(ref _cameraRef);
			set => SetProperty(ref _cameraRef, value);
		}

		[Ordinal(7)] 
		[RED("cameraTransformLS")] 
		public Transform CameraTransformLS
		{
			get => GetProperty(ref _cameraTransformLS);
			set => SetProperty(ref _cameraTransformLS, value);
		}

		public scneventsCameraPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
