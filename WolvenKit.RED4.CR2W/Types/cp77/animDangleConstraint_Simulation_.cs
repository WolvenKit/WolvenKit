using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_Simulation_ : ISerializable
	{
		private CArray<animCollisionRoundedShape> _collisionRoundedShapes;
		private rRef<JsonResource> _jsonCollisionShapes;
		private CBool _jsonCollisionShapesLoadedSuccessfully;
		private CFloat _alpha;
		private CBool _rotateParentToLookAtDangle;
		private CBool _parentRotationAltersTransformsOfDangleAndItsChildren;
		private CBool _parentRotationAltersTransformsOfNonDanglesAndItsChildren;
		private CBool _dangleAltersTransformsOfItsChildren;

		[Ordinal(0)] 
		[RED("collisionRoundedShapes")] 
		public CArray<animCollisionRoundedShape> CollisionRoundedShapes
		{
			get => GetProperty(ref _collisionRoundedShapes);
			set => SetProperty(ref _collisionRoundedShapes, value);
		}

		[Ordinal(1)] 
		[RED("jsonCollisionShapes")] 
		public rRef<JsonResource> JsonCollisionShapes
		{
			get => GetProperty(ref _jsonCollisionShapes);
			set => SetProperty(ref _jsonCollisionShapes, value);
		}

		[Ordinal(2)] 
		[RED("jsonCollisionShapesLoadedSuccessfully")] 
		public CBool JsonCollisionShapesLoadedSuccessfully
		{
			get => GetProperty(ref _jsonCollisionShapesLoadedSuccessfully);
			set => SetProperty(ref _jsonCollisionShapesLoadedSuccessfully, value);
		}

		[Ordinal(3)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}

		[Ordinal(4)] 
		[RED("rotateParentToLookAtDangle")] 
		public CBool RotateParentToLookAtDangle
		{
			get => GetProperty(ref _rotateParentToLookAtDangle);
			set => SetProperty(ref _rotateParentToLookAtDangle, value);
		}

		[Ordinal(5)] 
		[RED("parentRotationAltersTransformsOfDangleAndItsChildren")] 
		public CBool ParentRotationAltersTransformsOfDangleAndItsChildren
		{
			get => GetProperty(ref _parentRotationAltersTransformsOfDangleAndItsChildren);
			set => SetProperty(ref _parentRotationAltersTransformsOfDangleAndItsChildren, value);
		}

		[Ordinal(6)] 
		[RED("parentRotationAltersTransformsOfNonDanglesAndItsChildren")] 
		public CBool ParentRotationAltersTransformsOfNonDanglesAndItsChildren
		{
			get => GetProperty(ref _parentRotationAltersTransformsOfNonDanglesAndItsChildren);
			set => SetProperty(ref _parentRotationAltersTransformsOfNonDanglesAndItsChildren, value);
		}

		[Ordinal(7)] 
		[RED("dangleAltersTransformsOfItsChildren")] 
		public CBool DangleAltersTransformsOfItsChildren
		{
			get => GetProperty(ref _dangleAltersTransformsOfItsChildren);
			set => SetProperty(ref _dangleAltersTransformsOfItsChildren, value);
		}

		public animDangleConstraint_Simulation_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
