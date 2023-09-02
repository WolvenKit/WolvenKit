using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAnimationTransforms : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("extractedMotion")] 
		public CArray<Transform> ExtractedMotion
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		[Ordinal(1)] 
		[RED("gatePosition")] 
		public Transform GatePosition
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(2)] 
		[RED("boneOffset")] 
		public Transform BoneOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(3)] 
		[RED("animsetHash")] 
		public CUInt64 AnimsetHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public gameAnimationTransforms()
		{
			ExtractedMotion = new();
			GatePosition = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			BoneOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
