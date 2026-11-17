using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDangleConstraint_SimulationPositionProjection : animDangleConstraint_SimulationSingleBone
	{
		[Ordinal(9)] 
		[RED("collisionCapsuleRadius")] 
		public CFloat CollisionCapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("collisionCapsuleHeightExtent")] 
		public CFloat CollisionCapsuleHeightExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("collisionCapsuleAxisLS")] 
		public Vector3 CollisionCapsuleAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(12)] 
		[RED("directionReferenceBone")] 
		public animTransformIndex DirectionReferenceBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
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
