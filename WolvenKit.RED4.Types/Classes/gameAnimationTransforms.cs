using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimationTransforms : RedBaseClass
	{
		private CArray<Transform> _extractedMotion;
		private Transform _gatePosition;
		private Transform _boneOffset;
		private CUInt64 _animsetHash;

		[Ordinal(0)] 
		[RED("extractedMotion")] 
		public CArray<Transform> ExtractedMotion
		{
			get => GetProperty(ref _extractedMotion);
			set => SetProperty(ref _extractedMotion, value);
		}

		[Ordinal(1)] 
		[RED("gatePosition")] 
		public Transform GatePosition
		{
			get => GetProperty(ref _gatePosition);
			set => SetProperty(ref _gatePosition, value);
		}

		[Ordinal(2)] 
		[RED("boneOffset")] 
		public Transform BoneOffset
		{
			get => GetProperty(ref _boneOffset);
			set => SetProperty(ref _boneOffset, value);
		}

		[Ordinal(3)] 
		[RED("animsetHash")] 
		public CUInt64 AnimsetHash
		{
			get => GetProperty(ref _animsetHash);
			set => SetProperty(ref _animsetHash, value);
		}
	}
}
