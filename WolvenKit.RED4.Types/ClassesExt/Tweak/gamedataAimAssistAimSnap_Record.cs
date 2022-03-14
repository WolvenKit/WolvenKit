
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistAimSnap_Record
	{
		[RED("adjustPitch")]
		[REDProperty(IsIgnored = true)]
		public CBool AdjustPitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("adjustYaw")]
		[REDProperty(IsIgnored = true)]
		public CBool AdjustYaw
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("cameraInputMagToBreak")]
		[REDProperty(IsIgnored = true)]
		public CFloat CameraInputMagToBreak
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("cancelWithRecoil")]
		[REDProperty(IsIgnored = true)]
		public CBool CancelWithRecoil
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("checkRange")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("easeIn")]
		[REDProperty(IsIgnored = true)]
		public CBool EaseIn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("easeOut")]
		[REDProperty(IsIgnored = true)]
		public CBool EaseOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("endOnAimingStopped")]
		[REDProperty(IsIgnored = true)]
		public CBool EndOnAimingStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("endOnCameraInputApplied")]
		[REDProperty(IsIgnored = true)]
		public CBool EndOnCameraInputApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("endOnTargetReached")]
		[REDProperty(IsIgnored = true)]
		public CBool EndOnTargetReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("endOnTimeExceeded")]
		[REDProperty(IsIgnored = true)]
		public CBool EndOnTimeExceeded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("evaluateTargets")]
		[REDProperty(IsIgnored = true)]
		public CBool EvaluateTargets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("precision")]
		[REDProperty(IsIgnored = true)]
		public CFloat Precision
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetAngleDistanceFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetAngleDistanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
