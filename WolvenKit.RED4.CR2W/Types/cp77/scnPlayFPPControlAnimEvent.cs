using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayFPPControlAnimEvent : scnPlayAnimEvent
	{
		private CHandle<scnAnimName> _gameplayAnimName;
		private CBool _fPPControlActive;
		private CEnum<scnfppBlendOverride> _blendOverride;
		private CBool _cameraUseTrajectorySpace;
		private CFloat _cameraBlendInDuration;
		private CFloat _cameraBlendOutDuration;
		private CBool _stayInScene;
		private CBool _idleIsMountedWorkspot;
		private CFloat _cameraParallaxWeight;
		private CEnum<scnfppParallaxSpace> _cameraParallaxSpace;
		private CFloat _vehicleProceduralCameraWeight;
		private CFloat _yawLimitLeft;
		private CFloat _yawLimitRight;
		private CFloat _pitchLimitTop;
		private CFloat _pitchLimitBottom;
		private CArray<scnfppGenderSpecificParams> _genderSpecificParams;

		[Ordinal(15)] 
		[RED("gameplayAnimName")] 
		public CHandle<scnAnimName> GameplayAnimName
		{
			get
			{
				if (_gameplayAnimName == null)
				{
					_gameplayAnimName = (CHandle<scnAnimName>) CR2WTypeManager.Create("handle:scnAnimName", "gameplayAnimName", cr2w, this);
				}
				return _gameplayAnimName;
			}
			set
			{
				if (_gameplayAnimName == value)
				{
					return;
				}
				_gameplayAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("FPPControlActive")] 
		public CBool FPPControlActive
		{
			get
			{
				if (_fPPControlActive == null)
				{
					_fPPControlActive = (CBool) CR2WTypeManager.Create("Bool", "FPPControlActive", cr2w, this);
				}
				return _fPPControlActive;
			}
			set
			{
				if (_fPPControlActive == value)
				{
					return;
				}
				_fPPControlActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("blendOverride")] 
		public CEnum<scnfppBlendOverride> BlendOverride
		{
			get
			{
				if (_blendOverride == null)
				{
					_blendOverride = (CEnum<scnfppBlendOverride>) CR2WTypeManager.Create("scnfppBlendOverride", "blendOverride", cr2w, this);
				}
				return _blendOverride;
			}
			set
			{
				if (_blendOverride == value)
				{
					return;
				}
				_blendOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("cameraUseTrajectorySpace")] 
		public CBool CameraUseTrajectorySpace
		{
			get
			{
				if (_cameraUseTrajectorySpace == null)
				{
					_cameraUseTrajectorySpace = (CBool) CR2WTypeManager.Create("Bool", "cameraUseTrajectorySpace", cr2w, this);
				}
				return _cameraUseTrajectorySpace;
			}
			set
			{
				if (_cameraUseTrajectorySpace == value)
				{
					return;
				}
				_cameraUseTrajectorySpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("cameraBlendInDuration")] 
		public CFloat CameraBlendInDuration
		{
			get
			{
				if (_cameraBlendInDuration == null)
				{
					_cameraBlendInDuration = (CFloat) CR2WTypeManager.Create("Float", "cameraBlendInDuration", cr2w, this);
				}
				return _cameraBlendInDuration;
			}
			set
			{
				if (_cameraBlendInDuration == value)
				{
					return;
				}
				_cameraBlendInDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("cameraBlendOutDuration")] 
		public CFloat CameraBlendOutDuration
		{
			get
			{
				if (_cameraBlendOutDuration == null)
				{
					_cameraBlendOutDuration = (CFloat) CR2WTypeManager.Create("Float", "cameraBlendOutDuration", cr2w, this);
				}
				return _cameraBlendOutDuration;
			}
			set
			{
				if (_cameraBlendOutDuration == value)
				{
					return;
				}
				_cameraBlendOutDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("stayInScene")] 
		public CBool StayInScene
		{
			get
			{
				if (_stayInScene == null)
				{
					_stayInScene = (CBool) CR2WTypeManager.Create("Bool", "stayInScene", cr2w, this);
				}
				return _stayInScene;
			}
			set
			{
				if (_stayInScene == value)
				{
					return;
				}
				_stayInScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("idleIsMountedWorkspot")] 
		public CBool IdleIsMountedWorkspot
		{
			get
			{
				if (_idleIsMountedWorkspot == null)
				{
					_idleIsMountedWorkspot = (CBool) CR2WTypeManager.Create("Bool", "idleIsMountedWorkspot", cr2w, this);
				}
				return _idleIsMountedWorkspot;
			}
			set
			{
				if (_idleIsMountedWorkspot == value)
				{
					return;
				}
				_idleIsMountedWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("cameraParallaxWeight")] 
		public CFloat CameraParallaxWeight
		{
			get
			{
				if (_cameraParallaxWeight == null)
				{
					_cameraParallaxWeight = (CFloat) CR2WTypeManager.Create("Float", "cameraParallaxWeight", cr2w, this);
				}
				return _cameraParallaxWeight;
			}
			set
			{
				if (_cameraParallaxWeight == value)
				{
					return;
				}
				_cameraParallaxWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("cameraParallaxSpace")] 
		public CEnum<scnfppParallaxSpace> CameraParallaxSpace
		{
			get
			{
				if (_cameraParallaxSpace == null)
				{
					_cameraParallaxSpace = (CEnum<scnfppParallaxSpace>) CR2WTypeManager.Create("scnfppParallaxSpace", "cameraParallaxSpace", cr2w, this);
				}
				return _cameraParallaxSpace;
			}
			set
			{
				if (_cameraParallaxSpace == value)
				{
					return;
				}
				_cameraParallaxSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get
			{
				if (_vehicleProceduralCameraWeight == null)
				{
					_vehicleProceduralCameraWeight = (CFloat) CR2WTypeManager.Create("Float", "vehicleProceduralCameraWeight", cr2w, this);
				}
				return _vehicleProceduralCameraWeight;
			}
			set
			{
				if (_vehicleProceduralCameraWeight == value)
				{
					return;
				}
				_vehicleProceduralCameraWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("yawLimitLeft")] 
		public CFloat YawLimitLeft
		{
			get
			{
				if (_yawLimitLeft == null)
				{
					_yawLimitLeft = (CFloat) CR2WTypeManager.Create("Float", "yawLimitLeft", cr2w, this);
				}
				return _yawLimitLeft;
			}
			set
			{
				if (_yawLimitLeft == value)
				{
					return;
				}
				_yawLimitLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("yawLimitRight")] 
		public CFloat YawLimitRight
		{
			get
			{
				if (_yawLimitRight == null)
				{
					_yawLimitRight = (CFloat) CR2WTypeManager.Create("Float", "yawLimitRight", cr2w, this);
				}
				return _yawLimitRight;
			}
			set
			{
				if (_yawLimitRight == value)
				{
					return;
				}
				_yawLimitRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("pitchLimitTop")] 
		public CFloat PitchLimitTop
		{
			get
			{
				if (_pitchLimitTop == null)
				{
					_pitchLimitTop = (CFloat) CR2WTypeManager.Create("Float", "pitchLimitTop", cr2w, this);
				}
				return _pitchLimitTop;
			}
			set
			{
				if (_pitchLimitTop == value)
				{
					return;
				}
				_pitchLimitTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("pitchLimitBottom")] 
		public CFloat PitchLimitBottom
		{
			get
			{
				if (_pitchLimitBottom == null)
				{
					_pitchLimitBottom = (CFloat) CR2WTypeManager.Create("Float", "pitchLimitBottom", cr2w, this);
				}
				return _pitchLimitBottom;
			}
			set
			{
				if (_pitchLimitBottom == value)
				{
					return;
				}
				_pitchLimitBottom = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("genderSpecificParams")] 
		public CArray<scnfppGenderSpecificParams> GenderSpecificParams
		{
			get
			{
				if (_genderSpecificParams == null)
				{
					_genderSpecificParams = (CArray<scnfppGenderSpecificParams>) CR2WTypeManager.Create("array:scnfppGenderSpecificParams", "genderSpecificParams", cr2w, this);
				}
				return _genderSpecificParams;
			}
			set
			{
				if (_genderSpecificParams == value)
				{
					return;
				}
				_genderSpecificParams = value;
				PropertySet(this);
			}
		}

		public scnPlayFPPControlAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
