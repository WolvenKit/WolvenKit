using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleData : animAnimFeature
	{
		private CBool _isInVehicle;
		private CBool _isDriver;
		private CInt32 _vehType;
		private CInt32 _vehSlot;
		private CBool _isInCombat;
		private CBool _isInWindowCombat;
		private CBool _isInDriverCombat;
		private CInt32 _vehClass;
		private CBool _isEnteringCombat;
		private CFloat _enteringCombatDuration;
		private CBool _isExitingCombat;
		private CFloat _exitingCombatDuration;
		private CBool _isEnteringVehicle;
		private CBool _isExitingVehicle;
		private CBool _isWorldRenderPlane;

		[Ordinal(0)] 
		[RED("isInVehicle")] 
		public CBool IsInVehicle
		{
			get
			{
				if (_isInVehicle == null)
				{
					_isInVehicle = (CBool) CR2WTypeManager.Create("Bool", "isInVehicle", cr2w, this);
				}
				return _isInVehicle;
			}
			set
			{
				if (_isInVehicle == value)
				{
					return;
				}
				_isInVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isDriver")] 
		public CBool IsDriver
		{
			get
			{
				if (_isDriver == null)
				{
					_isDriver = (CBool) CR2WTypeManager.Create("Bool", "isDriver", cr2w, this);
				}
				return _isDriver;
			}
			set
			{
				if (_isDriver == value)
				{
					return;
				}
				_isDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehType")] 
		public CInt32 VehType
		{
			get
			{
				if (_vehType == null)
				{
					_vehType = (CInt32) CR2WTypeManager.Create("Int32", "vehType", cr2w, this);
				}
				return _vehType;
			}
			set
			{
				if (_vehType == value)
				{
					return;
				}
				_vehType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vehSlot")] 
		public CInt32 VehSlot
		{
			get
			{
				if (_vehSlot == null)
				{
					_vehSlot = (CInt32) CR2WTypeManager.Create("Int32", "vehSlot", cr2w, this);
				}
				return _vehSlot;
			}
			set
			{
				if (_vehSlot == value)
				{
					return;
				}
				_vehSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get
			{
				if (_isInCombat == null)
				{
					_isInCombat = (CBool) CR2WTypeManager.Create("Bool", "isInCombat", cr2w, this);
				}
				return _isInCombat;
			}
			set
			{
				if (_isInCombat == value)
				{
					return;
				}
				_isInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isInWindowCombat")] 
		public CBool IsInWindowCombat
		{
			get
			{
				if (_isInWindowCombat == null)
				{
					_isInWindowCombat = (CBool) CR2WTypeManager.Create("Bool", "isInWindowCombat", cr2w, this);
				}
				return _isInWindowCombat;
			}
			set
			{
				if (_isInWindowCombat == value)
				{
					return;
				}
				_isInWindowCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get
			{
				if (_isInDriverCombat == null)
				{
					_isInDriverCombat = (CBool) CR2WTypeManager.Create("Bool", "isInDriverCombat", cr2w, this);
				}
				return _isInDriverCombat;
			}
			set
			{
				if (_isInDriverCombat == value)
				{
					return;
				}
				_isInDriverCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vehClass")] 
		public CInt32 VehClass
		{
			get
			{
				if (_vehClass == null)
				{
					_vehClass = (CInt32) CR2WTypeManager.Create("Int32", "vehClass", cr2w, this);
				}
				return _vehClass;
			}
			set
			{
				if (_vehClass == value)
				{
					return;
				}
				_vehClass = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isEnteringCombat")] 
		public CBool IsEnteringCombat
		{
			get
			{
				if (_isEnteringCombat == null)
				{
					_isEnteringCombat = (CBool) CR2WTypeManager.Create("Bool", "isEnteringCombat", cr2w, this);
				}
				return _isEnteringCombat;
			}
			set
			{
				if (_isEnteringCombat == value)
				{
					return;
				}
				_isEnteringCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enteringCombatDuration")] 
		public CFloat EnteringCombatDuration
		{
			get
			{
				if (_enteringCombatDuration == null)
				{
					_enteringCombatDuration = (CFloat) CR2WTypeManager.Create("Float", "enteringCombatDuration", cr2w, this);
				}
				return _enteringCombatDuration;
			}
			set
			{
				if (_enteringCombatDuration == value)
				{
					return;
				}
				_enteringCombatDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isExitingCombat")] 
		public CBool IsExitingCombat
		{
			get
			{
				if (_isExitingCombat == null)
				{
					_isExitingCombat = (CBool) CR2WTypeManager.Create("Bool", "isExitingCombat", cr2w, this);
				}
				return _isExitingCombat;
			}
			set
			{
				if (_isExitingCombat == value)
				{
					return;
				}
				_isExitingCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("exitingCombatDuration")] 
		public CFloat ExitingCombatDuration
		{
			get
			{
				if (_exitingCombatDuration == null)
				{
					_exitingCombatDuration = (CFloat) CR2WTypeManager.Create("Float", "exitingCombatDuration", cr2w, this);
				}
				return _exitingCombatDuration;
			}
			set
			{
				if (_exitingCombatDuration == value)
				{
					return;
				}
				_exitingCombatDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isEnteringVehicle")] 
		public CBool IsEnteringVehicle
		{
			get
			{
				if (_isEnteringVehicle == null)
				{
					_isEnteringVehicle = (CBool) CR2WTypeManager.Create("Bool", "isEnteringVehicle", cr2w, this);
				}
				return _isEnteringVehicle;
			}
			set
			{
				if (_isEnteringVehicle == value)
				{
					return;
				}
				_isEnteringVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isExitingVehicle")] 
		public CBool IsExitingVehicle
		{
			get
			{
				if (_isExitingVehicle == null)
				{
					_isExitingVehicle = (CBool) CR2WTypeManager.Create("Bool", "isExitingVehicle", cr2w, this);
				}
				return _isExitingVehicle;
			}
			set
			{
				if (_isExitingVehicle == value)
				{
					return;
				}
				_isExitingVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isWorldRenderPlane")] 
		public CBool IsWorldRenderPlane
		{
			get
			{
				if (_isWorldRenderPlane == null)
				{
					_isWorldRenderPlane = (CBool) CR2WTypeManager.Create("Bool", "isWorldRenderPlane", cr2w, this);
				}
				return _isWorldRenderPlane;
			}
			set
			{
				if (_isWorldRenderPlane == value)
				{
					return;
				}
				_isWorldRenderPlane = value;
				PropertySet(this);
			}
		}

		public AnimFeature_VehicleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
