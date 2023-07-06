using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsPhysicalJointPin : ISerializable
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CHandle<physicsISystemObject> Object
		{
			get => GetPropertyValue<CHandle<physicsISystemObject>>();
			set => SetPropertyValue<CHandle<physicsISystemObject>>(value);
		}

		[Ordinal(1)] 
		[RED("featureIndex")] 
		public CInt32 FeatureIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("localPosition")] 
		public Vector3 LocalPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("localRotation")] 
		public Quaternion LocalRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public physicsPhysicalJointPin()
		{
			FeatureIndex = -1;
			LocalPosition = new Vector3();
			LocalRotation = new Quaternion { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
