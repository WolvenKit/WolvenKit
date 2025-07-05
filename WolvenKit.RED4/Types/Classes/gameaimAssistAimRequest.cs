using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaimAssistAimRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("adjustPitch")] 
		public CBool AdjustPitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("adjustYaw")] 
		public CBool AdjustYaw
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("endOnTargetReached")] 
		public CBool EndOnTargetReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("endOnCameraInputApplied")] 
		public CBool EndOnCameraInputApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("endOnTimeExceeded")] 
		public CBool EndOnTimeExceeded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("endOnAimingStopped")] 
		public CBool EndOnAimingStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("cameraInputMagToBreak")] 
		public CFloat CameraInputMagToBreak
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("cameraMouseInputMagToBreak")] 
		public CFloat CameraMouseInputMagToBreak
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("precision")] 
		public CFloat Precision
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("maxDuration")] 
		public CFloat MaxDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("easeIn")] 
		public CBool EaseIn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("easeOut")] 
		public CBool EaseOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("checkRange")] 
		public CBool CheckRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("lookAtTarget")] 
		public Vector4 LookAtTarget
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(15)] 
		[RED("processAsInput")] 
		public CBool ProcessAsInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("bodyPartsTracking")] 
		public CBool BodyPartsTracking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("bptMaxDot")] 
		public CFloat BptMaxDot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("bptMaxSwitches")] 
		public CFloat BptMaxSwitches
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("bptMinInputMag")] 
		public CFloat BptMinInputMag
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("bptMinResetInputMag")] 
		public CFloat BptMinResetInputMag
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaimAssistAimRequest()
		{
			CheckRange = true;
			LookAtTarget = new Vector4();
			ProcessAsInput = true;
			BptMaxSwitches = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
