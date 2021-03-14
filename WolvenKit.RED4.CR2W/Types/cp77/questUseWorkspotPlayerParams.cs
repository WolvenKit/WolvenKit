using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotPlayerParams : CVariable
	{
		private CEnum<questUseWorkspotTier> _tier;
		private gameTier3CameraSettings _cameraSettings;
		private CBool _emptyHands;
		private CBool _cameraUseTrajectorySpace;
		private CBool _applyCameraParams;
		private CFloat _vehicleProceduralCameraWeight;
		private CFloat _parallaxWeight;
		private CEnum<questCameraParallaxSpace> _parallaxSpace;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<questUseWorkspotTier> Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (CEnum<questUseWorkspotTier>) CR2WTypeManager.Create("questUseWorkspotTier", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cameraSettings")] 
		public gameTier3CameraSettings CameraSettings
		{
			get
			{
				if (_cameraSettings == null)
				{
					_cameraSettings = (gameTier3CameraSettings) CR2WTypeManager.Create("gameTier3CameraSettings", "cameraSettings", cr2w, this);
				}
				return _cameraSettings;
			}
			set
			{
				if (_cameraSettings == value)
				{
					return;
				}
				_cameraSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get
			{
				if (_emptyHands == null)
				{
					_emptyHands = (CBool) CR2WTypeManager.Create("Bool", "emptyHands", cr2w, this);
				}
				return _emptyHands;
			}
			set
			{
				if (_emptyHands == value)
				{
					return;
				}
				_emptyHands = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("applyCameraParams")] 
		public CBool ApplyCameraParams
		{
			get
			{
				if (_applyCameraParams == null)
				{
					_applyCameraParams = (CBool) CR2WTypeManager.Create("Bool", "applyCameraParams", cr2w, this);
				}
				return _applyCameraParams;
			}
			set
			{
				if (_applyCameraParams == value)
				{
					return;
				}
				_applyCameraParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("parallaxWeight")] 
		public CFloat ParallaxWeight
		{
			get
			{
				if (_parallaxWeight == null)
				{
					_parallaxWeight = (CFloat) CR2WTypeManager.Create("Float", "parallaxWeight", cr2w, this);
				}
				return _parallaxWeight;
			}
			set
			{
				if (_parallaxWeight == value)
				{
					return;
				}
				_parallaxWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("parallaxSpace")] 
		public CEnum<questCameraParallaxSpace> ParallaxSpace
		{
			get
			{
				if (_parallaxSpace == null)
				{
					_parallaxSpace = (CEnum<questCameraParallaxSpace>) CR2WTypeManager.Create("questCameraParallaxSpace", "parallaxSpace", cr2w, this);
				}
				return _parallaxSpace;
			}
			set
			{
				if (_parallaxSpace == value)
				{
					return;
				}
				_parallaxSpace = value;
				PropertySet(this);
			}
		}

		public questUseWorkspotPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
