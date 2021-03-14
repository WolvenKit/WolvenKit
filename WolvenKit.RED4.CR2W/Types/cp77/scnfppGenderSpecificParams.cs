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
			get
			{
				if (_genderMask == null)
				{
					_genderMask = (scnGenderMask) CR2WTypeManager.Create("scnGenderMask", "genderMask", cr2w, this);
				}
				return _genderMask;
			}
			set
			{
				if (_genderMask == value)
				{
					return;
				}
				_genderMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitionBlendInTrajectorySpaceAngles")] 
		public CArray<EulerAngles> TransitionBlendInTrajectorySpaceAngles
		{
			get
			{
				if (_transitionBlendInTrajectorySpaceAngles == null)
				{
					_transitionBlendInTrajectorySpaceAngles = (CArray<EulerAngles>) CR2WTypeManager.Create("array:EulerAngles", "transitionBlendInTrajectorySpaceAngles", cr2w, this);
				}
				return _transitionBlendInTrajectorySpaceAngles;
			}
			set
			{
				if (_transitionBlendInTrajectorySpaceAngles == value)
				{
					return;
				}
				_transitionBlendInTrajectorySpaceAngles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transitionBlendInCameraSpace")] 
		public CArray<CFloat> TransitionBlendInCameraSpace
		{
			get
			{
				if (_transitionBlendInCameraSpace == null)
				{
					_transitionBlendInCameraSpace = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "transitionBlendInCameraSpace", cr2w, this);
				}
				return _transitionBlendInCameraSpace;
			}
			set
			{
				if (_transitionBlendInCameraSpace == value)
				{
					return;
				}
				_transitionBlendInCameraSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionEndInputAngles")] 
		public CArray<EulerAngles> TransitionEndInputAngles
		{
			get
			{
				if (_transitionEndInputAngles == null)
				{
					_transitionEndInputAngles = (CArray<EulerAngles>) CR2WTypeManager.Create("array:EulerAngles", "transitionEndInputAngles", cr2w, this);
				}
				return _transitionEndInputAngles;
			}
			set
			{
				if (_transitionEndInputAngles == value)
				{
					return;
				}
				_transitionEndInputAngles = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("idleCameraLs")] 
		public EulerAngles IdleCameraLs
		{
			get
			{
				if (_idleCameraLs == null)
				{
					_idleCameraLs = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "idleCameraLs", cr2w, this);
				}
				return _idleCameraLs;
			}
			set
			{
				if (_idleCameraLs == value)
				{
					return;
				}
				_idleCameraLs = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("idleControlCameraMs")] 
		public EulerAngles IdleControlCameraMs
		{
			get
			{
				if (_idleControlCameraMs == null)
				{
					_idleControlCameraMs = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "idleControlCameraMs", cr2w, this);
				}
				return _idleControlCameraMs;
			}
			set
			{
				if (_idleControlCameraMs == value)
				{
					return;
				}
				_idleControlCameraMs = value;
				PropertySet(this);
			}
		}

		public scnfppGenderSpecificParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
