using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cursorDeviceGameController : gameuiWidgetGameController
	{
		private CHandle<gameIBlackboard> _bbUIData;
		private wCHandle<gameIBlackboard> _bbWeaponInfo;
		private CUInt32 _bbWeaponEventId;
		private CUInt32 _bbPlayerTierEventId;
		private CUInt32 _interactionBlackboardId;
		private CUInt32 _upperBodyStateBlackboardId;
		private CEnum<GameplayTier> _sceneTier;
		private CEnum<gamePSMUpperBodyStates> _upperBodyState;
		private CBool _isUnarmed;
		private wCHandle<inkImageWidget> _cursorDevice;
		private CHandle<inkanimDefinition> _fadeOutAnimation;
		private CHandle<inkanimDefinition> _fadeInAnimation;
		private CBool _wasLastInteractionWithDevice;
		private CBool _interactionDeviceState;

		[Ordinal(2)] 
		[RED("bbUIData")] 
		public CHandle<gameIBlackboard> BbUIData
		{
			get
			{
				if (_bbUIData == null)
				{
					_bbUIData = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbUIData", cr2w, this);
				}
				return _bbUIData;
			}
			set
			{
				if (_bbUIData == value)
				{
					return;
				}
				_bbUIData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bbWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbWeaponInfo
		{
			get
			{
				if (_bbWeaponInfo == null)
				{
					_bbWeaponInfo = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bbWeaponInfo", cr2w, this);
				}
				return _bbWeaponInfo;
			}
			set
			{
				if (_bbWeaponInfo == value)
				{
					return;
				}
				_bbWeaponInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bbWeaponEventId")] 
		public CUInt32 BbWeaponEventId
		{
			get
			{
				if (_bbWeaponEventId == null)
				{
					_bbWeaponEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbWeaponEventId", cr2w, this);
				}
				return _bbWeaponEventId;
			}
			set
			{
				if (_bbWeaponEventId == value)
				{
					return;
				}
				_bbWeaponEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bbPlayerTierEventId")] 
		public CUInt32 BbPlayerTierEventId
		{
			get
			{
				if (_bbPlayerTierEventId == null)
				{
					_bbPlayerTierEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerTierEventId", cr2w, this);
				}
				return _bbPlayerTierEventId;
			}
			set
			{
				if (_bbPlayerTierEventId == value)
				{
					return;
				}
				_bbPlayerTierEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("interactionBlackboardId")] 
		public CUInt32 InteractionBlackboardId
		{
			get
			{
				if (_interactionBlackboardId == null)
				{
					_interactionBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "interactionBlackboardId", cr2w, this);
				}
				return _interactionBlackboardId;
			}
			set
			{
				if (_interactionBlackboardId == value)
				{
					return;
				}
				_interactionBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("upperBodyStateBlackboardId")] 
		public CUInt32 UpperBodyStateBlackboardId
		{
			get
			{
				if (_upperBodyStateBlackboardId == null)
				{
					_upperBodyStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "upperBodyStateBlackboardId", cr2w, this);
				}
				return _upperBodyStateBlackboardId;
			}
			set
			{
				if (_upperBodyStateBlackboardId == value)
				{
					return;
				}
				_upperBodyStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get
			{
				if (_sceneTier == null)
				{
					_sceneTier = (CEnum<GameplayTier>) CR2WTypeManager.Create("GameplayTier", "sceneTier", cr2w, this);
				}
				return _sceneTier;
			}
			set
			{
				if (_sceneTier == value)
				{
					return;
				}
				_sceneTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get
			{
				if (_upperBodyState == null)
				{
					_upperBodyState = (CEnum<gamePSMUpperBodyStates>) CR2WTypeManager.Create("gamePSMUpperBodyStates", "upperBodyState", cr2w, this);
				}
				return _upperBodyState;
			}
			set
			{
				if (_upperBodyState == value)
				{
					return;
				}
				_upperBodyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get
			{
				if (_isUnarmed == null)
				{
					_isUnarmed = (CBool) CR2WTypeManager.Create("Bool", "isUnarmed", cr2w, this);
				}
				return _isUnarmed;
			}
			set
			{
				if (_isUnarmed == value)
				{
					return;
				}
				_isUnarmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("cursorDevice")] 
		public wCHandle<inkImageWidget> CursorDevice
		{
			get
			{
				if (_cursorDevice == null)
				{
					_cursorDevice = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "cursorDevice", cr2w, this);
				}
				return _cursorDevice;
			}
			set
			{
				if (_cursorDevice == value)
				{
					return;
				}
				_cursorDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fadeOutAnimation")] 
		public CHandle<inkanimDefinition> FadeOutAnimation
		{
			get
			{
				if (_fadeOutAnimation == null)
				{
					_fadeOutAnimation = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "fadeOutAnimation", cr2w, this);
				}
				return _fadeOutAnimation;
			}
			set
			{
				if (_fadeOutAnimation == value)
				{
					return;
				}
				_fadeOutAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fadeInAnimation")] 
		public CHandle<inkanimDefinition> FadeInAnimation
		{
			get
			{
				if (_fadeInAnimation == null)
				{
					_fadeInAnimation = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "fadeInAnimation", cr2w, this);
				}
				return _fadeInAnimation;
			}
			set
			{
				if (_fadeInAnimation == value)
				{
					return;
				}
				_fadeInAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("wasLastInteractionWithDevice")] 
		public CBool WasLastInteractionWithDevice
		{
			get
			{
				if (_wasLastInteractionWithDevice == null)
				{
					_wasLastInteractionWithDevice = (CBool) CR2WTypeManager.Create("Bool", "wasLastInteractionWithDevice", cr2w, this);
				}
				return _wasLastInteractionWithDevice;
			}
			set
			{
				if (_wasLastInteractionWithDevice == value)
				{
					return;
				}
				_wasLastInteractionWithDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("interactionDeviceState")] 
		public CBool InteractionDeviceState
		{
			get
			{
				if (_interactionDeviceState == null)
				{
					_interactionDeviceState = (CBool) CR2WTypeManager.Create("Bool", "interactionDeviceState", cr2w, this);
				}
				return _interactionDeviceState;
			}
			set
			{
				if (_interactionDeviceState == value)
				{
					return;
				}
				_interactionDeviceState = value;
				PropertySet(this);
			}
		}

		public cursorDeviceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
