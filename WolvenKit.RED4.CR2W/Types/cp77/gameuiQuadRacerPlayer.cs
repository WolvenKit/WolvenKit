using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerPlayer : gameuiSideScrollerMiniGamePlayerController
	{
		private inkImageWidgetReference _playerImage;
		private inkImageWidgetReference _leftTireSmoke;
		private inkImageWidgetReference _rightTireSmoke;
		private inkImageWidgetReference _rightFlame;
		private inkImageWidgetReference _leftFlame;
		private CName _leftTurnAtlasRegion;
		private CName _rightTurnAtlasRegion;
		private CName _straightTurnAtlasRegion;

		[Ordinal(1)] 
		[RED("playerImage")] 
		public inkImageWidgetReference PlayerImage
		{
			get
			{
				if (_playerImage == null)
				{
					_playerImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "playerImage", cr2w, this);
				}
				return _playerImage;
			}
			set
			{
				if (_playerImage == value)
				{
					return;
				}
				_playerImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("leftTireSmoke")] 
		public inkImageWidgetReference LeftTireSmoke
		{
			get
			{
				if (_leftTireSmoke == null)
				{
					_leftTireSmoke = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "leftTireSmoke", cr2w, this);
				}
				return _leftTireSmoke;
			}
			set
			{
				if (_leftTireSmoke == value)
				{
					return;
				}
				_leftTireSmoke = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rightTireSmoke")] 
		public inkImageWidgetReference RightTireSmoke
		{
			get
			{
				if (_rightTireSmoke == null)
				{
					_rightTireSmoke = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "rightTireSmoke", cr2w, this);
				}
				return _rightTireSmoke;
			}
			set
			{
				if (_rightTireSmoke == value)
				{
					return;
				}
				_rightTireSmoke = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rightFlame")] 
		public inkImageWidgetReference RightFlame
		{
			get
			{
				if (_rightFlame == null)
				{
					_rightFlame = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "rightFlame", cr2w, this);
				}
				return _rightFlame;
			}
			set
			{
				if (_rightFlame == value)
				{
					return;
				}
				_rightFlame = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("leftFlame")] 
		public inkImageWidgetReference LeftFlame
		{
			get
			{
				if (_leftFlame == null)
				{
					_leftFlame = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "leftFlame", cr2w, this);
				}
				return _leftFlame;
			}
			set
			{
				if (_leftFlame == value)
				{
					return;
				}
				_leftFlame = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("leftTurnAtlasRegion")] 
		public CName LeftTurnAtlasRegion
		{
			get
			{
				if (_leftTurnAtlasRegion == null)
				{
					_leftTurnAtlasRegion = (CName) CR2WTypeManager.Create("CName", "leftTurnAtlasRegion", cr2w, this);
				}
				return _leftTurnAtlasRegion;
			}
			set
			{
				if (_leftTurnAtlasRegion == value)
				{
					return;
				}
				_leftTurnAtlasRegion = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rightTurnAtlasRegion")] 
		public CName RightTurnAtlasRegion
		{
			get
			{
				if (_rightTurnAtlasRegion == null)
				{
					_rightTurnAtlasRegion = (CName) CR2WTypeManager.Create("CName", "rightTurnAtlasRegion", cr2w, this);
				}
				return _rightTurnAtlasRegion;
			}
			set
			{
				if (_rightTurnAtlasRegion == value)
				{
					return;
				}
				_rightTurnAtlasRegion = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("straightTurnAtlasRegion")] 
		public CName StraightTurnAtlasRegion
		{
			get
			{
				if (_straightTurnAtlasRegion == null)
				{
					_straightTurnAtlasRegion = (CName) CR2WTypeManager.Create("CName", "straightTurnAtlasRegion", cr2w, this);
				}
				return _straightTurnAtlasRegion;
			}
			set
			{
				if (_straightTurnAtlasRegion == value)
				{
					return;
				}
				_straightTurnAtlasRegion = value;
				PropertySet(this);
			}
		}

		public gameuiQuadRacerPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
