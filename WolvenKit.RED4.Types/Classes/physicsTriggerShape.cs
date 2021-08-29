using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsTriggerShape : RedBaseClass
	{
		private CEnum<physicsShapeType> _shapeType;
		private Vector3 _shapeSize;
		private Transform _shapeLocalPose;

		[Ordinal(0)] 
		[RED("shapeType")] 
		public CEnum<physicsShapeType> ShapeType
		{
			get => GetProperty(ref _shapeType);
			set => SetProperty(ref _shapeType, value);
		}

		[Ordinal(1)] 
		[RED("shapeSize")] 
		public Vector3 ShapeSize
		{
			get => GetProperty(ref _shapeSize);
			set => SetProperty(ref _shapeSize, value);
		}

		[Ordinal(2)] 
		[RED("shapeLocalPose")] 
		public Transform ShapeLocalPose
		{
			get => GetProperty(ref _shapeLocalPose);
			set => SetProperty(ref _shapeLocalPose, value);
		}
	}
}
