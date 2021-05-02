using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimationTransforms : CVariable
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

		public gameAnimationTransforms(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
