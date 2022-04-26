using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnfppGenderSpecificParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("genderMask")] 
		public scnGenderMask GenderMask
		{
			get => GetPropertyValue<scnGenderMask>();
			set => SetPropertyValue<scnGenderMask>(value);
		}

		[Ordinal(1)] 
		[RED("transitionBlendInTrajectorySpaceAngles")] 
		public CArray<EulerAngles> TransitionBlendInTrajectorySpaceAngles
		{
			get => GetPropertyValue<CArray<EulerAngles>>();
			set => SetPropertyValue<CArray<EulerAngles>>(value);
		}

		[Ordinal(2)] 
		[RED("transitionBlendInCameraSpace")] 
		public CArray<CFloat> TransitionBlendInCameraSpace
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("transitionEndInputAngles")] 
		public CArray<EulerAngles> TransitionEndInputAngles
		{
			get => GetPropertyValue<CArray<EulerAngles>>();
			set => SetPropertyValue<CArray<EulerAngles>>(value);
		}

		[Ordinal(4)] 
		[RED("idleCameraLs")] 
		public EulerAngles IdleCameraLs
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(5)] 
		[RED("idleControlCameraMs")] 
		public EulerAngles IdleControlCameraMs
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		public scnfppGenderSpecificParams()
		{
			GenderMask = new() { Mask = 4 };
			TransitionBlendInTrajectorySpaceAngles = new();
			TransitionBlendInCameraSpace = new();
			TransitionEndInputAngles = new();
			IdleCameraLs = new();
			IdleControlCameraMs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
