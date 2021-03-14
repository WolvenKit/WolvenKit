using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		private CHandle<gameIBlackboard> _weaponLocalBB;
		private CUInt32 _weaponBBID;
		private CHandle<inkanimProxy> _animationProxy;
		private inkCanvasWidgetReference _cori_S;
		private inkCanvasWidgetReference _cori_M;
		private CFloat _rightStickX;
		private CFloat _rightStickY;

		[Ordinal(18)] 
		[RED("weaponLocalBB")] 
		public CHandle<gameIBlackboard> WeaponLocalBB
		{
			get
			{
				if (_weaponLocalBB == null)
				{
					_weaponLocalBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponLocalBB", cr2w, this);
				}
				return _weaponLocalBB;
			}
			set
			{
				if (_weaponLocalBB == value)
				{
					return;
				}
				_weaponLocalBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weaponBBID")] 
		public CUInt32 WeaponBBID
		{
			get
			{
				if (_weaponBBID == null)
				{
					_weaponBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponBBID", cr2w, this);
				}
				return _weaponBBID;
			}
			set
			{
				if (_weaponBBID == value)
				{
					return;
				}
				_weaponBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get
			{
				if (_cori_S == null)
				{
					_cori_S = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "Cori_S", cr2w, this);
				}
				return _cori_S;
			}
			set
			{
				if (_cori_S == value)
				{
					return;
				}
				_cori_S = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get
			{
				if (_cori_M == null)
				{
					_cori_M = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "Cori_M", cr2w, this);
				}
				return _cori_M;
			}
			set
			{
				if (_cori_M == value)
				{
					return;
				}
				_cori_M = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get
			{
				if (_rightStickX == null)
				{
					_rightStickX = (CFloat) CR2WTypeManager.Create("Float", "rightStickX", cr2w, this);
				}
				return _rightStickX;
			}
			set
			{
				if (_rightStickX == value)
				{
					return;
				}
				_rightStickX = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get
			{
				if (_rightStickY == null)
				{
					_rightStickY = (CFloat) CR2WTypeManager.Create("Float", "rightStickY", cr2w, this);
				}
				return _rightStickY;
			}
			set
			{
				if (_rightStickY == value)
				{
					return;
				}
				_rightStickY = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Launcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
