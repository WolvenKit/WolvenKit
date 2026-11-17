using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsTriggerShape : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("shapeType")] 
		public CEnum<physicsShapeType> ShapeType
		{
			get => GetPropertyValue<CEnum<physicsShapeType>>();
			set => SetPropertyValue<CEnum<physicsShapeType>>(value);
		}

		[Ordinal(1)] 
		[RED("shapeSize")] 
		public Vector3 ShapeSize
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("shapeLocalPose")] 
		public Transform ShapeLocalPose
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public physicsTriggerShape()
		{
			ShapeSize = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			ShapeLocalPose = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
