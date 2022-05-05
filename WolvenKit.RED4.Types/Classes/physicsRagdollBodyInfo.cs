using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsRagdollBodyInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ParentAnimIndex")] 
		public CInt32 ParentAnimIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("ChildAnimIndex")] 
		public CInt32 ChildAnimIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("ParentBodyIndex")] 
		public CInt32 ParentBodyIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("BodyPart")] 
		public CBitField<physicsRagdollBodyPartE> BodyPart
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}

		[Ordinal(4)] 
		[RED("ShapeType")] 
		public CEnum<physicsRagdollShapeType> ShapeType
		{
			get => GetPropertyValue<CEnum<physicsRagdollShapeType>>();
			set => SetPropertyValue<CEnum<physicsRagdollShapeType>>(value);
		}

		[Ordinal(5)] 
		[RED("ShapeRadius")] 
		public CFloat ShapeRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("HalfHeight")] 
		public CFloat HalfHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("ShapeLocalTranslation")] 
		public Vector3 ShapeLocalTranslation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("ShapeLocalRotation")] 
		public Quaternion ShapeLocalRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(9)] 
		[RED("IsRootDisplacementPart")] 
		public CBool IsRootDisplacementPart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("SwingAnglesY", 2)] 
		public CArrayFixedSize<CFloat> SwingAnglesY
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("SwingAnglesZ", 2)] 
		public CArrayFixedSize<CFloat> SwingAnglesZ
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("TwistAngles", 2)] 
		public CArrayFixedSize<CFloat> TwistAngles
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(13)] 
		[RED("IsStiff")] 
		public CBool IsStiff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("ExcludeFromEarlyCollision")] 
		public CBool ExcludeFromEarlyCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("FilterDataOverride")] 
		public CName FilterDataOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public physicsRagdollBodyInfo()
		{
			ParentAnimIndex = -1;
			ChildAnimIndex = -1;
			ParentBodyIndex = -1;
			ShapeRadius = 0.050000F;
			HalfHeight = 0.050000F;
			ShapeLocalTranslation = new();
			ShapeLocalRotation = new() { R = 1.000000F };
			SwingAnglesY = new(2);
			SwingAnglesZ = new(2);
			TwistAngles = new(2);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
