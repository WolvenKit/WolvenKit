using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsPhysicalJointPin : ISerializable
	{
		private CHandle<physicsISystemObject> _object;
		private CInt32 _featureIndex;
		private Vector3 _localPosition;
		private Quaternion _localRotation;

		[Ordinal(0)] 
		[RED("object")] 
		public CHandle<physicsISystemObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("featureIndex")] 
		public CInt32 FeatureIndex
		{
			get => GetProperty(ref _featureIndex);
			set => SetProperty(ref _featureIndex, value);
		}

		[Ordinal(2)] 
		[RED("localPosition")] 
		public Vector3 LocalPosition
		{
			get => GetProperty(ref _localPosition);
			set => SetProperty(ref _localPosition, value);
		}

		[Ordinal(3)] 
		[RED("localRotation")] 
		public Quaternion LocalRotation
		{
			get => GetProperty(ref _localRotation);
			set => SetProperty(ref _localRotation, value);
		}
	}
}
