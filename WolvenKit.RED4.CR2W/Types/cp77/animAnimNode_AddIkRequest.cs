using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddIkRequest : animAnimNode_OnePoseInput
	{
		private CName _ikChain;
		private animTransformIndex _targetBone;
		private Vector3 _positionOffset;
		private Quaternion _rotationOffset;
		private animPoleVectorDetails _poleVector;
		private CFloat _weightPosition;
		private CFloat _weightRotation;
		private CFloat _blendTimeIn;
		private CFloat _blendTimeOut;
		private CInt32 _priority;

		[Ordinal(12)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetProperty(ref _ikChain);
			set => SetProperty(ref _ikChain, value);
		}

		[Ordinal(13)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get => GetProperty(ref _targetBone);
			set => SetProperty(ref _targetBone, value);
		}

		[Ordinal(14)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}

		[Ordinal(15)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get => GetProperty(ref _rotationOffset);
			set => SetProperty(ref _rotationOffset, value);
		}

		[Ordinal(16)] 
		[RED("poleVector")] 
		public animPoleVectorDetails PoleVector
		{
			get => GetProperty(ref _poleVector);
			set => SetProperty(ref _poleVector, value);
		}

		[Ordinal(17)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get => GetProperty(ref _weightPosition);
			set => SetProperty(ref _weightPosition, value);
		}

		[Ordinal(18)] 
		[RED("weightRotation")] 
		public CFloat WeightRotation
		{
			get => GetProperty(ref _weightRotation);
			set => SetProperty(ref _weightRotation, value);
		}

		[Ordinal(19)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get => GetProperty(ref _blendTimeIn);
			set => SetProperty(ref _blendTimeIn, value);
		}

		[Ordinal(20)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get => GetProperty(ref _blendTimeOut);
			set => SetProperty(ref _blendTimeOut, value);
		}

		[Ordinal(21)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		public animAnimNode_AddIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
