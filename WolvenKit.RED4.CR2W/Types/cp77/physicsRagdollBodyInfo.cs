using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyInfo : CVariable
	{
		private CInt32 _parentAnimIndex;
		private CInt32 _childAnimIndex;
		private CInt32 _parentBodyIndex;
		private CEnum<physicsRagdollBodyPartE> _bodyPart;
		private CEnum<physicsRagdollShapeType> _shapeType;
		private CFloat _shapeRadius;
		private CFloat _halfHeight;
		private Vector3 _shapeLocalTranslation;
		private Quaternion _shapeLocalRotation;
		private CBool _isRootDisplacementPart;
		private CArrayFixedSize<CFloat> _swingAnglesY;
		private CArrayFixedSize<CFloat> _swingAnglesZ;
		private CArrayFixedSize<CFloat> _twistAngles;
		private CBool _isStiff;
		private CBool _excludeFromEarlyCollision;
		private CName _filterDataOverride;

		[Ordinal(0)] 
		[RED("ParentAnimIndex")] 
		public CInt32 ParentAnimIndex
		{
			get => GetProperty(ref _parentAnimIndex);
			set => SetProperty(ref _parentAnimIndex, value);
		}

		[Ordinal(1)] 
		[RED("ChildAnimIndex")] 
		public CInt32 ChildAnimIndex
		{
			get => GetProperty(ref _childAnimIndex);
			set => SetProperty(ref _childAnimIndex, value);
		}

		[Ordinal(2)] 
		[RED("ParentBodyIndex")] 
		public CInt32 ParentBodyIndex
		{
			get => GetProperty(ref _parentBodyIndex);
			set => SetProperty(ref _parentBodyIndex, value);
		}

		[Ordinal(3)] 
		[RED("BodyPart")] 
		public CEnum<physicsRagdollBodyPartE> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(4)] 
		[RED("ShapeType")] 
		public CEnum<physicsRagdollShapeType> ShapeType
		{
			get => GetProperty(ref _shapeType);
			set => SetProperty(ref _shapeType, value);
		}

		[Ordinal(5)] 
		[RED("ShapeRadius")] 
		public CFloat ShapeRadius
		{
			get => GetProperty(ref _shapeRadius);
			set => SetProperty(ref _shapeRadius, value);
		}

		[Ordinal(6)] 
		[RED("HalfHeight")] 
		public CFloat HalfHeight
		{
			get => GetProperty(ref _halfHeight);
			set => SetProperty(ref _halfHeight, value);
		}

		[Ordinal(7)] 
		[RED("ShapeLocalTranslation")] 
		public Vector3 ShapeLocalTranslation
		{
			get => GetProperty(ref _shapeLocalTranslation);
			set => SetProperty(ref _shapeLocalTranslation, value);
		}

		[Ordinal(8)] 
		[RED("ShapeLocalRotation")] 
		public Quaternion ShapeLocalRotation
		{
			get => GetProperty(ref _shapeLocalRotation);
			set => SetProperty(ref _shapeLocalRotation, value);
		}

		[Ordinal(9)] 
		[RED("IsRootDisplacementPart")] 
		public CBool IsRootDisplacementPart
		{
			get => GetProperty(ref _isRootDisplacementPart);
			set => SetProperty(ref _isRootDisplacementPart, value);
		}

		[Ordinal(10)] 
		[RED("SwingAnglesY", 2)] 
		public CArrayFixedSize<CFloat> SwingAnglesY
		{
			get => GetProperty(ref _swingAnglesY);
			set => SetProperty(ref _swingAnglesY, value);
		}

		[Ordinal(11)] 
		[RED("SwingAnglesZ", 2)] 
		public CArrayFixedSize<CFloat> SwingAnglesZ
		{
			get => GetProperty(ref _swingAnglesZ);
			set => SetProperty(ref _swingAnglesZ, value);
		}

		[Ordinal(12)] 
		[RED("TwistAngles", 2)] 
		public CArrayFixedSize<CFloat> TwistAngles
		{
			get => GetProperty(ref _twistAngles);
			set => SetProperty(ref _twistAngles, value);
		}

		[Ordinal(13)] 
		[RED("IsStiff")] 
		public CBool IsStiff
		{
			get => GetProperty(ref _isStiff);
			set => SetProperty(ref _isStiff, value);
		}

		[Ordinal(14)] 
		[RED("ExcludeFromEarlyCollision")] 
		public CBool ExcludeFromEarlyCollision
		{
			get => GetProperty(ref _excludeFromEarlyCollision);
			set => SetProperty(ref _excludeFromEarlyCollision, value);
		}

		[Ordinal(15)] 
		[RED("FilterDataOverride")] 
		public CName FilterDataOverride
		{
			get => GetProperty(ref _filterDataOverride);
			set => SetProperty(ref _filterDataOverride, value);
		}

		public physicsRagdollBodyInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
