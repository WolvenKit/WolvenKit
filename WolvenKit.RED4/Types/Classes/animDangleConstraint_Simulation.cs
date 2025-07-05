using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class animDangleConstraint_Simulation : ISerializable
	{
		[Ordinal(0)] 
		[RED("collisionRoundedShapes")] 
		public CArray<animCollisionRoundedShape> CollisionRoundedShapes
		{
			get => GetPropertyValue<CArray<animCollisionRoundedShape>>();
			set => SetPropertyValue<CArray<animCollisionRoundedShape>>(value);
		}

		[Ordinal(1)] 
		[RED("jsonCollisionShapes")] 
		public CResourceReference<JsonResource> JsonCollisionShapes
		{
			get => GetPropertyValue<CResourceReference<JsonResource>>();
			set => SetPropertyValue<CResourceReference<JsonResource>>(value);
		}

		[Ordinal(2)] 
		[RED("jsonCollisionShapesLoadedSuccessfully")] 
		public CBool JsonCollisionShapesLoadedSuccessfully
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rotateParentToLookAtDangle")] 
		public CBool RotateParentToLookAtDangle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("parentRotationAltersTransformsOfDangleAndItsChildren")] 
		public CBool ParentRotationAltersTransformsOfDangleAndItsChildren
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("parentRotationAltersTransformsOfNonDanglesAndItsChildren")] 
		public CBool ParentRotationAltersTransformsOfNonDanglesAndItsChildren
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("dangleAltersTransformsOfItsChildren")] 
		public CBool DangleAltersTransformsOfItsChildren
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animDangleConstraint_Simulation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
