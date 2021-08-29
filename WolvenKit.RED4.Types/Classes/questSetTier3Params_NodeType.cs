using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetTier3Params_NodeType : questISceneManagerNodeType
	{
		private CFloat _yawLeftLimit;
		private CFloat _yawRightLimit;
		private CFloat _pitchUpLimit;
		private CFloat _pitchDownLimit;
		private CFloat _yawSpeedMultiplier;
		private CFloat _pitchSpeedMultiplier;
		private gameEntityReference _objectRef;
		private CName _slotName;
		private Vector3 _offsetPos;
		private CFloat _rotationTime;
		private CBool _rotateHeadOnly;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;

		[Ordinal(0)] 
		[RED("yawLeftLimit")] 
		public CFloat YawLeftLimit
		{
			get => GetProperty(ref _yawLeftLimit);
			set => SetProperty(ref _yawLeftLimit, value);
		}

		[Ordinal(1)] 
		[RED("yawRightLimit")] 
		public CFloat YawRightLimit
		{
			get => GetProperty(ref _yawRightLimit);
			set => SetProperty(ref _yawRightLimit, value);
		}

		[Ordinal(2)] 
		[RED("pitchUpLimit")] 
		public CFloat PitchUpLimit
		{
			get => GetProperty(ref _pitchUpLimit);
			set => SetProperty(ref _pitchUpLimit, value);
		}

		[Ordinal(3)] 
		[RED("pitchDownLimit")] 
		public CFloat PitchDownLimit
		{
			get => GetProperty(ref _pitchDownLimit);
			set => SetProperty(ref _pitchDownLimit, value);
		}

		[Ordinal(4)] 
		[RED("yawSpeedMultiplier")] 
		public CFloat YawSpeedMultiplier
		{
			get => GetProperty(ref _yawSpeedMultiplier);
			set => SetProperty(ref _yawSpeedMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("pitchSpeedMultiplier")] 
		public CFloat PitchSpeedMultiplier
		{
			get => GetProperty(ref _pitchSpeedMultiplier);
			set => SetProperty(ref _pitchSpeedMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(8)] 
		[RED("offsetPos")] 
		public Vector3 OffsetPos
		{
			get => GetProperty(ref _offsetPos);
			set => SetProperty(ref _offsetPos, value);
		}

		[Ordinal(9)] 
		[RED("rotationTime")] 
		public CFloat RotationTime
		{
			get => GetProperty(ref _rotationTime);
			set => SetProperty(ref _rotationTime, value);
		}

		[Ordinal(10)] 
		[RED("rotateHeadOnly")] 
		public CBool RotateHeadOnly
		{
			get => GetProperty(ref _rotateHeadOnly);
			set => SetProperty(ref _rotateHeadOnly, value);
		}

		[Ordinal(11)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get => GetProperty(ref _usePlayerWorkspot);
			set => SetProperty(ref _usePlayerWorkspot, value);
		}

		[Ordinal(12)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get => GetProperty(ref _useEnterAnim);
			set => SetProperty(ref _useEnterAnim, value);
		}

		[Ordinal(13)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get => GetProperty(ref _useExitAnim);
			set => SetProperty(ref _useExitAnim, value);
		}
	}
}
