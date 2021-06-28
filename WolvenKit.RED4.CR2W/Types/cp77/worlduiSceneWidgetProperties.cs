using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worlduiSceneWidgetProperties : CVariable
	{
		private Vector2 _projectionPlaneSize;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CBool _isInteractable;
		private CBool _isInteractableFromBehind;
		private CFloat _maxInteractionDistance;
		private CBool _useCustomFaceVector;
		private Vector3 _faceVector;

		[Ordinal(0)] 
		[RED("projectionPlaneSize")] 
		public Vector2 ProjectionPlaneSize
		{
			get => GetProperty(ref _projectionPlaneSize);
			set => SetProperty(ref _projectionPlaneSize, value);
		}

		[Ordinal(1)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetProperty(ref _renderingPlane);
			set => SetProperty(ref _renderingPlane, value);
		}

		[Ordinal(2)] 
		[RED("isInteractable")] 
		public CBool IsInteractable
		{
			get => GetProperty(ref _isInteractable);
			set => SetProperty(ref _isInteractable, value);
		}

		[Ordinal(3)] 
		[RED("isInteractableFromBehind")] 
		public CBool IsInteractableFromBehind
		{
			get => GetProperty(ref _isInteractableFromBehind);
			set => SetProperty(ref _isInteractableFromBehind, value);
		}

		[Ordinal(4)] 
		[RED("maxInteractionDistance")] 
		public CFloat MaxInteractionDistance
		{
			get => GetProperty(ref _maxInteractionDistance);
			set => SetProperty(ref _maxInteractionDistance, value);
		}

		[Ordinal(5)] 
		[RED("useCustomFaceVector")] 
		public CBool UseCustomFaceVector
		{
			get => GetProperty(ref _useCustomFaceVector);
			set => SetProperty(ref _useCustomFaceVector, value);
		}

		[Ordinal(6)] 
		[RED("faceVector")] 
		public Vector3 FaceVector
		{
			get => GetProperty(ref _faceVector);
			set => SetProperty(ref _faceVector, value);
		}

		public worlduiSceneWidgetProperties(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
