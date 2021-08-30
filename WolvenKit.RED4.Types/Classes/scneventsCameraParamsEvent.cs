using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsCameraParamsEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private CFloat _fovValue;
		private CFloat _fovWeigh;
		private CFloat _dofIntensity;
		private CFloat _dofNearBlur;
		private CFloat _dofNearFocus;
		private CFloat _dofFarBlur;
		private CFloat _dofFarFocus;
		private CBool _useNearPlane;
		private CBool _useFarPlane;
		private CBool _isPlayerCamera;
		private scneventsCameraOverrideSettings _cameraOverrideSettings;
		private scnPerformerId _targetActor;
		private CName _targetSlot;

		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetProperty(ref _cameraRef);
			set => SetProperty(ref _cameraRef, value);
		}

		[Ordinal(7)] 
		[RED("fovValue")] 
		public CFloat FovValue
		{
			get => GetProperty(ref _fovValue);
			set => SetProperty(ref _fovValue, value);
		}

		[Ordinal(8)] 
		[RED("fovWeigh")] 
		public CFloat FovWeigh
		{
			get => GetProperty(ref _fovWeigh);
			set => SetProperty(ref _fovWeigh, value);
		}

		[Ordinal(9)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get => GetProperty(ref _dofIntensity);
			set => SetProperty(ref _dofIntensity, value);
		}

		[Ordinal(10)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get => GetProperty(ref _dofNearBlur);
			set => SetProperty(ref _dofNearBlur, value);
		}

		[Ordinal(11)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get => GetProperty(ref _dofNearFocus);
			set => SetProperty(ref _dofNearFocus, value);
		}

		[Ordinal(12)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get => GetProperty(ref _dofFarBlur);
			set => SetProperty(ref _dofFarBlur, value);
		}

		[Ordinal(13)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get => GetProperty(ref _dofFarFocus);
			set => SetProperty(ref _dofFarFocus, value);
		}

		[Ordinal(14)] 
		[RED("useNearPlane")] 
		public CBool UseNearPlane
		{
			get => GetProperty(ref _useNearPlane);
			set => SetProperty(ref _useNearPlane, value);
		}

		[Ordinal(15)] 
		[RED("useFarPlane")] 
		public CBool UseFarPlane
		{
			get => GetProperty(ref _useFarPlane);
			set => SetProperty(ref _useFarPlane, value);
		}

		[Ordinal(16)] 
		[RED("isPlayerCamera")] 
		public CBool IsPlayerCamera
		{
			get => GetProperty(ref _isPlayerCamera);
			set => SetProperty(ref _isPlayerCamera, value);
		}

		[Ordinal(17)] 
		[RED("cameraOverrideSettings")] 
		public scneventsCameraOverrideSettings CameraOverrideSettings
		{
			get => GetProperty(ref _cameraOverrideSettings);
			set => SetProperty(ref _cameraOverrideSettings, value);
		}

		[Ordinal(18)] 
		[RED("targetActor")] 
		public scnPerformerId TargetActor
		{
			get => GetProperty(ref _targetActor);
			set => SetProperty(ref _targetActor, value);
		}

		[Ordinal(19)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}

		public scneventsCameraParamsEvent()
		{
			_fovValue = 51.000000F;
			_fovWeigh = 1.000000F;
			_useNearPlane = true;
			_useFarPlane = true;
		}
	}
}
