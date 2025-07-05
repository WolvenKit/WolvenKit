using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(14)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("collisionCapsuleAxisLS")] 
		public Vector3 CollisionCapsuleAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(17)] 
		[RED("directionReferenceBone")] 
		public animTransformIndex DirectionReferenceBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(18)] 
		[RED("projectionType")] 
		public CEnum<animPositionProjectionType> ProjectionType
		{
			get => GetPropertyValue<CEnum<animPositionProjectionType>>();
			set => SetPropertyValue<CEnum<animPositionProjectionType>>(value);
		}

		public animDangleConstraint_SimulationPositionProjection()
		{
			CollisionRoundedShapes = new();
			JsonCollisionShapesLoadedSuccessfully = true;
			Alpha = 1.000000F;
			RotateParentToLookAtDangle = true;
			ParentRotationAltersTransformsOfDangleAndItsChildren = true;
			ParentRotationAltersTransformsOfNonDanglesAndItsChildren = true;
			DangleAltersTransformsOfItsChildren = true;
			DangleBone = new animTransformIndex();
			CollisionCapsuleAxisLS = new Vector3 { X = 0.500000F };
			DirectionReferenceBone = new animTransformIndex();
			ProjectionType = Enums.animPositionProjectionType.ShortestPath;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
