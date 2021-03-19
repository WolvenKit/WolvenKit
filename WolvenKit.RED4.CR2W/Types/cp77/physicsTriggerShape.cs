using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsTriggerShape : CVariable
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

		public physicsTriggerShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
