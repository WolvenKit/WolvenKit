using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsCameraParamsEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("fovValue")] 
		public CFloat FovValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("fovWeigh")] 
		public CFloat FovWeigh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("useNearPlane")] 
		public CBool UseNearPlane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("useFarPlane")] 
		public CBool UseFarPlane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isPlayerCamera")] 
		public CBool IsPlayerCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("cameraOverrideSettings")] 
		public scneventsCameraOverrideSettings CameraOverrideSettings
		{
			get => GetPropertyValue<scneventsCameraOverrideSettings>();
			set => SetPropertyValue<scneventsCameraOverrideSettings>(value);
		}

		[Ordinal(18)] 
		[RED("targetActor")] 
		public scnPerformerId TargetActor
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(19)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scneventsCameraParamsEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			FovValue = 51.000000F;
			FovWeigh = 1.000000F;
			UseNearPlane = true;
			UseFarPlane = true;
			CameraOverrideSettings = new scneventsCameraOverrideSettings { OverrideFov = true, OverrideDof = true };
			TargetActor = new scnPerformerId { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
