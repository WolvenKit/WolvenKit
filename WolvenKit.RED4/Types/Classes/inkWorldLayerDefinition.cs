using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWorldLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("projectionPlaneSize")] 
		public Vector2 ProjectionPlaneSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(9)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetPropertyValue<CEnum<ERenderingPlane>>();
			set => SetPropertyValue<CEnum<ERenderingPlane>>(value);
		}

		[Ordinal(10)] 
		[RED("isAlwaysVisible")] 
		public CBool IsAlwaysVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isInteractableFromBehind")] 
		public CBool IsInteractableFromBehind
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("maxInteractionDistance")] 
		public CFloat MaxInteractionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("useCustomFaceVector")] 
		public CBool UseCustomFaceVector
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("faceVector")] 
		public Vector3 FaceVector
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public inkWorldLayerDefinition()
		{
			ActiveByDefault = true;
			ProjectionPlaneSize = new Vector2 { X = 1.000000F, Y = 1.000000F };
			FaceVector = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
