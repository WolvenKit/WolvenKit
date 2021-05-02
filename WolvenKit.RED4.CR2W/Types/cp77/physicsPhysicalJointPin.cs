using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicalJointPin : ISerializable
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

		public physicsPhysicalJointPin(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
