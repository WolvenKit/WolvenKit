using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnfppGenderSpecificParams : CVariable
	{
		private scnGenderMask _genderMask;
		private CArray<EulerAngles> _transitionBlendInTrajectorySpaceAngles;
		private CArray<CFloat> _transitionBlendInCameraSpace;
		private CArray<EulerAngles> _transitionEndInputAngles;
		private EulerAngles _idleCameraLs;
		private EulerAngles _idleControlCameraMs;

		[Ordinal(0)] 
		[RED("genderMask")] 
		public scnGenderMask GenderMask
		{
			get => GetProperty(ref _genderMask);
			set => SetProperty(ref _genderMask, value);
		}

		[Ordinal(1)] 
		[RED("transitionBlendInTrajectorySpaceAngles")] 
		public CArray<EulerAngles> TransitionBlendInTrajectorySpaceAngles
		{
			get => GetProperty(ref _transitionBlendInTrajectorySpaceAngles);
			set => SetProperty(ref _transitionBlendInTrajectorySpaceAngles, value);
		}

		[Ordinal(2)] 
		[RED("transitionBlendInCameraSpace")] 
		public CArray<CFloat> TransitionBlendInCameraSpace
		{
			get => GetProperty(ref _transitionBlendInCameraSpace);
			set => SetProperty(ref _transitionBlendInCameraSpace, value);
		}

		[Ordinal(3)] 
		[RED("transitionEndInputAngles")] 
		public CArray<EulerAngles> TransitionEndInputAngles
		{
			get => GetProperty(ref _transitionEndInputAngles);
			set => SetProperty(ref _transitionEndInputAngles, value);
		}

		[Ordinal(4)] 
		[RED("idleCameraLs")] 
		public EulerAngles IdleCameraLs
		{
			get => GetProperty(ref _idleCameraLs);
			set => SetProperty(ref _idleCameraLs, value);
		}

		[Ordinal(5)] 
		[RED("idleControlCameraMs")] 
		public EulerAngles IdleControlCameraMs
		{
			get => GetProperty(ref _idleControlCameraMs);
			set => SetProperty(ref _idleControlCameraMs, value);
		}

		public scnfppGenderSpecificParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
