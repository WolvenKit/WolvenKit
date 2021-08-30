using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaimAssistAimRequest : RedBaseClass
	{
		private CFloat _duration;
		private CBool _adjustPitch;
		private CBool _adjustYaw;
		private CBool _endOnTargetReached;
		private CBool _endOnCameraInputApplied;
		private CBool _endOnTimeExceeded;
		private CBool _endOnAimingStopped;
		private CFloat _cameraInputMagToBreak;
		private CFloat _precision;
		private CFloat _maxDuration;
		private CBool _easeIn;
		private CBool _easeOut;
		private CBool _checkRange;
		private Vector4 _lookAtTarget;
		private CBool _processAsInput;
		private CBool _bodyPartsTracking;
		private CFloat _bptMaxDot;
		private CFloat _bptMaxSwitches;
		private CFloat _bptMinInputMag;
		private CFloat _bptMinResetInputMag;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("adjustPitch")] 
		public CBool AdjustPitch
		{
			get => GetProperty(ref _adjustPitch);
			set => SetProperty(ref _adjustPitch, value);
		}

		[Ordinal(2)] 
		[RED("adjustYaw")] 
		public CBool AdjustYaw
		{
			get => GetProperty(ref _adjustYaw);
			set => SetProperty(ref _adjustYaw, value);
		}

		[Ordinal(3)] 
		[RED("endOnTargetReached")] 
		public CBool EndOnTargetReached
		{
			get => GetProperty(ref _endOnTargetReached);
			set => SetProperty(ref _endOnTargetReached, value);
		}

		[Ordinal(4)] 
		[RED("endOnCameraInputApplied")] 
		public CBool EndOnCameraInputApplied
		{
			get => GetProperty(ref _endOnCameraInputApplied);
			set => SetProperty(ref _endOnCameraInputApplied, value);
		}

		[Ordinal(5)] 
		[RED("endOnTimeExceeded")] 
		public CBool EndOnTimeExceeded
		{
			get => GetProperty(ref _endOnTimeExceeded);
			set => SetProperty(ref _endOnTimeExceeded, value);
		}

		[Ordinal(6)] 
		[RED("endOnAimingStopped")] 
		public CBool EndOnAimingStopped
		{
			get => GetProperty(ref _endOnAimingStopped);
			set => SetProperty(ref _endOnAimingStopped, value);
		}

		[Ordinal(7)] 
		[RED("cameraInputMagToBreak")] 
		public CFloat CameraInputMagToBreak
		{
			get => GetProperty(ref _cameraInputMagToBreak);
			set => SetProperty(ref _cameraInputMagToBreak, value);
		}

		[Ordinal(8)] 
		[RED("precision")] 
		public CFloat Precision
		{
			get => GetProperty(ref _precision);
			set => SetProperty(ref _precision, value);
		}

		[Ordinal(9)] 
		[RED("maxDuration")] 
		public CFloat MaxDuration
		{
			get => GetProperty(ref _maxDuration);
			set => SetProperty(ref _maxDuration, value);
		}

		[Ordinal(10)] 
		[RED("easeIn")] 
		public CBool EaseIn
		{
			get => GetProperty(ref _easeIn);
			set => SetProperty(ref _easeIn, value);
		}

		[Ordinal(11)] 
		[RED("easeOut")] 
		public CBool EaseOut
		{
			get => GetProperty(ref _easeOut);
			set => SetProperty(ref _easeOut, value);
		}

		[Ordinal(12)] 
		[RED("checkRange")] 
		public CBool CheckRange
		{
			get => GetProperty(ref _checkRange);
			set => SetProperty(ref _checkRange, value);
		}

		[Ordinal(13)] 
		[RED("lookAtTarget")] 
		public Vector4 LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(14)] 
		[RED("processAsInput")] 
		public CBool ProcessAsInput
		{
			get => GetProperty(ref _processAsInput);
			set => SetProperty(ref _processAsInput, value);
		}

		[Ordinal(15)] 
		[RED("bodyPartsTracking")] 
		public CBool BodyPartsTracking
		{
			get => GetProperty(ref _bodyPartsTracking);
			set => SetProperty(ref _bodyPartsTracking, value);
		}

		[Ordinal(16)] 
		[RED("bptMaxDot")] 
		public CFloat BptMaxDot
		{
			get => GetProperty(ref _bptMaxDot);
			set => SetProperty(ref _bptMaxDot, value);
		}

		[Ordinal(17)] 
		[RED("bptMaxSwitches")] 
		public CFloat BptMaxSwitches
		{
			get => GetProperty(ref _bptMaxSwitches);
			set => SetProperty(ref _bptMaxSwitches, value);
		}

		[Ordinal(18)] 
		[RED("bptMinInputMag")] 
		public CFloat BptMinInputMag
		{
			get => GetProperty(ref _bptMinInputMag);
			set => SetProperty(ref _bptMinInputMag, value);
		}

		[Ordinal(19)] 
		[RED("bptMinResetInputMag")] 
		public CFloat BptMinResetInputMag
		{
			get => GetProperty(ref _bptMinResetInputMag);
			set => SetProperty(ref _bptMinResetInputMag, value);
		}

		public gameaimAssistAimRequest()
		{
			_checkRange = true;
			_processAsInput = true;
			_bptMaxSwitches = -1.000000F;
		}
	}
}
