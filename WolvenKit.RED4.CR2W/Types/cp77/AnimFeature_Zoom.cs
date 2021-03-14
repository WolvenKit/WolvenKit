using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Zoom : animAnimFeature
	{
		private CFloat _finalZoomLevel;
		private CFloat _weaponZoomLevel;
		private CFloat _weaponAimFOV;
		private CFloat _worldFOV;
		private CInt32 _zoomLevelNum;
		private CFloat _noWeaponAimInTime;
		private CFloat _noWeaponAimOutTime;
		private CBool _shouldUseWeaponZoomStats;
		private CBool _focusModeActive;
		private CFloat _weaponScopeFov;

		[Ordinal(0)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get
			{
				if (_finalZoomLevel == null)
				{
					_finalZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "finalZoomLevel", cr2w, this);
				}
				return _finalZoomLevel;
			}
			set
			{
				if (_finalZoomLevel == value)
				{
					return;
				}
				_finalZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get
			{
				if (_weaponZoomLevel == null)
				{
					_weaponZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "weaponZoomLevel", cr2w, this);
				}
				return _weaponZoomLevel;
			}
			set
			{
				if (_weaponZoomLevel == value)
				{
					return;
				}
				_weaponZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weaponAimFOV")] 
		public CFloat WeaponAimFOV
		{
			get
			{
				if (_weaponAimFOV == null)
				{
					_weaponAimFOV = (CFloat) CR2WTypeManager.Create("Float", "weaponAimFOV", cr2w, this);
				}
				return _weaponAimFOV;
			}
			set
			{
				if (_weaponAimFOV == value)
				{
					return;
				}
				_weaponAimFOV = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("worldFOV")] 
		public CFloat WorldFOV
		{
			get
			{
				if (_worldFOV == null)
				{
					_worldFOV = (CFloat) CR2WTypeManager.Create("Float", "worldFOV", cr2w, this);
				}
				return _worldFOV;
			}
			set
			{
				if (_worldFOV == value)
				{
					return;
				}
				_worldFOV = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get
			{
				if (_zoomLevelNum == null)
				{
					_zoomLevelNum = (CInt32) CR2WTypeManager.Create("Int32", "zoomLevelNum", cr2w, this);
				}
				return _zoomLevelNum;
			}
			set
			{
				if (_zoomLevelNum == value)
				{
					return;
				}
				_zoomLevelNum = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("noWeaponAimInTime")] 
		public CFloat NoWeaponAimInTime
		{
			get
			{
				if (_noWeaponAimInTime == null)
				{
					_noWeaponAimInTime = (CFloat) CR2WTypeManager.Create("Float", "noWeaponAimInTime", cr2w, this);
				}
				return _noWeaponAimInTime;
			}
			set
			{
				if (_noWeaponAimInTime == value)
				{
					return;
				}
				_noWeaponAimInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("noWeaponAimOutTime")] 
		public CFloat NoWeaponAimOutTime
		{
			get
			{
				if (_noWeaponAimOutTime == null)
				{
					_noWeaponAimOutTime = (CFloat) CR2WTypeManager.Create("Float", "noWeaponAimOutTime", cr2w, this);
				}
				return _noWeaponAimOutTime;
			}
			set
			{
				if (_noWeaponAimOutTime == value)
				{
					return;
				}
				_noWeaponAimOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("shouldUseWeaponZoomStats")] 
		public CBool ShouldUseWeaponZoomStats
		{
			get
			{
				if (_shouldUseWeaponZoomStats == null)
				{
					_shouldUseWeaponZoomStats = (CBool) CR2WTypeManager.Create("Bool", "shouldUseWeaponZoomStats", cr2w, this);
				}
				return _shouldUseWeaponZoomStats;
			}
			set
			{
				if (_shouldUseWeaponZoomStats == value)
				{
					return;
				}
				_shouldUseWeaponZoomStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get
			{
				if (_focusModeActive == null)
				{
					_focusModeActive = (CBool) CR2WTypeManager.Create("Bool", "focusModeActive", cr2w, this);
				}
				return _focusModeActive;
			}
			set
			{
				if (_focusModeActive == value)
				{
					return;
				}
				_focusModeActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("weaponScopeFov")] 
		public CFloat WeaponScopeFov
		{
			get
			{
				if (_weaponScopeFov == null)
				{
					_weaponScopeFov = (CFloat) CR2WTypeManager.Create("Float", "weaponScopeFov", cr2w, this);
				}
				return _weaponScopeFov;
			}
			set
			{
				if (_weaponScopeFov == value)
				{
					return;
				}
				_weaponScopeFov = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Zoom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
