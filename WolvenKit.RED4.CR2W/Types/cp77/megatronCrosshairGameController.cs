using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronCrosshairGameController : gameuiWidgetGameController
	{
		private CUInt32 _bulletSpreedBlackboardId;
		private CUInt32 _crosshairStateBlackboardId;
		private wCHandle<inkImageWidget> _leftPart;
		private wCHandle<inkImageWidget> _rightPart;
		private wCHandle<inkImageWidget> _nearCenterPart;
		private wCHandle<inkImageWidget> _farCenterPart;
		private Vector2 _bufferedSpread;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private Vector2 _orgSideSize;
		private CFloat _minSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CEnum<gamePSMCrosshairStates> _crosshairState;

		[Ordinal(2)] 
		[RED("bulletSpreedBlackboardId")] 
		public CUInt32 BulletSpreedBlackboardId
		{
			get
			{
				if (_bulletSpreedBlackboardId == null)
				{
					_bulletSpreedBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "bulletSpreedBlackboardId", cr2w, this);
				}
				return _bulletSpreedBlackboardId;
			}
			set
			{
				if (_bulletSpreedBlackboardId == value)
				{
					return;
				}
				_bulletSpreedBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("crosshairStateBlackboardId")] 
		public CUInt32 CrosshairStateBlackboardId
		{
			get
			{
				if (_crosshairStateBlackboardId == null)
				{
					_crosshairStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "crosshairStateBlackboardId", cr2w, this);
				}
				return _crosshairStateBlackboardId;
			}
			set
			{
				if (_crosshairStateBlackboardId == value)
				{
					return;
				}
				_crosshairStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("leftPart")] 
		public wCHandle<inkImageWidget> LeftPart
		{
			get
			{
				if (_leftPart == null)
				{
					_leftPart = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "leftPart", cr2w, this);
				}
				return _leftPart;
			}
			set
			{
				if (_leftPart == value)
				{
					return;
				}
				_leftPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rightPart")] 
		public wCHandle<inkImageWidget> RightPart
		{
			get
			{
				if (_rightPart == null)
				{
					_rightPart = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "rightPart", cr2w, this);
				}
				return _rightPart;
			}
			set
			{
				if (_rightPart == value)
				{
					return;
				}
				_rightPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("nearCenterPart")] 
		public wCHandle<inkImageWidget> NearCenterPart
		{
			get
			{
				if (_nearCenterPart == null)
				{
					_nearCenterPart = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "nearCenterPart", cr2w, this);
				}
				return _nearCenterPart;
			}
			set
			{
				if (_nearCenterPart == value)
				{
					return;
				}
				_nearCenterPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("farCenterPart")] 
		public wCHandle<inkImageWidget> FarCenterPart
		{
			get
			{
				if (_farCenterPart == null)
				{
					_farCenterPart = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "farCenterPart", cr2w, this);
				}
				return _farCenterPart;
			}
			set
			{
				if (_farCenterPart == value)
				{
					return;
				}
				_farCenterPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get
			{
				if (_bufferedSpread == null)
				{
					_bufferedSpread = (Vector2) CR2WTypeManager.Create("Vector2", "bufferedSpread", cr2w, this);
				}
				return _bufferedSpread;
			}
			set
			{
				if (_bufferedSpread == value)
				{
					return;
				}
				_bufferedSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("weaponlocalBB")] 
		public CHandle<gameIBlackboard> WeaponlocalBB
		{
			get
			{
				if (_weaponlocalBB == null)
				{
					_weaponlocalBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponlocalBB", cr2w, this);
				}
				return _weaponlocalBB;
			}
			set
			{
				if (_weaponlocalBB == value)
				{
					return;
				}
				_weaponlocalBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("orgSideSize")] 
		public Vector2 OrgSideSize
		{
			get
			{
				if (_orgSideSize == null)
				{
					_orgSideSize = (Vector2) CR2WTypeManager.Create("Vector2", "orgSideSize", cr2w, this);
				}
				return _orgSideSize;
			}
			set
			{
				if (_orgSideSize == value)
				{
					return;
				}
				_orgSideSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("minSpread")] 
		public CFloat MinSpread
		{
			get
			{
				if (_minSpread == null)
				{
					_minSpread = (CFloat) CR2WTypeManager.Create("Float", "minSpread", cr2w, this);
				}
				return _minSpread;
			}
			set
			{
				if (_minSpread == value)
				{
					return;
				}
				_minSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get
			{
				if (_gameplaySpreadMultiplier == null)
				{
					_gameplaySpreadMultiplier = (CFloat) CR2WTypeManager.Create("Float", "gameplaySpreadMultiplier", cr2w, this);
				}
				return _gameplaySpreadMultiplier;
			}
			set
			{
				if (_gameplaySpreadMultiplier == value)
				{
					return;
				}
				_gameplaySpreadMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get
			{
				if (_crosshairState == null)
				{
					_crosshairState = (CEnum<gamePSMCrosshairStates>) CR2WTypeManager.Create("gamePSMCrosshairStates", "crosshairState", cr2w, this);
				}
				return _crosshairState;
			}
			set
			{
				if (_crosshairState == value)
				{
					return;
				}
				_crosshairState = value;
				PropertySet(this);
			}
		}

		public megatronCrosshairGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
