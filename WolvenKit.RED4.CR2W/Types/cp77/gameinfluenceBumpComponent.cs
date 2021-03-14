using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpComponent : entIPlacedComponent
	{
		private CBool _isPlayerControlled;
		private CFloat _movementSpreadDistance;
		private CFloat _movementSpreadRadius;
		private CFloat _distanceToReactBack;
		private CFloat _distanceToReactFront;
		private CArray<gameinfluenceBumpReactionSetting> _reactionSettings;
		private CBool _autoPlayBumpAnimation;
		private CBool _isEnabled;
		private CBool _isBumpable;

		[Ordinal(5)] 
		[RED("isPlayerControlled")] 
		public CBool IsPlayerControlled
		{
			get
			{
				if (_isPlayerControlled == null)
				{
					_isPlayerControlled = (CBool) CR2WTypeManager.Create("Bool", "isPlayerControlled", cr2w, this);
				}
				return _isPlayerControlled;
			}
			set
			{
				if (_isPlayerControlled == value)
				{
					return;
				}
				_isPlayerControlled = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("movementSpreadDistance")] 
		public CFloat MovementSpreadDistance
		{
			get
			{
				if (_movementSpreadDistance == null)
				{
					_movementSpreadDistance = (CFloat) CR2WTypeManager.Create("Float", "movementSpreadDistance", cr2w, this);
				}
				return _movementSpreadDistance;
			}
			set
			{
				if (_movementSpreadDistance == value)
				{
					return;
				}
				_movementSpreadDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("movementSpreadRadius")] 
		public CFloat MovementSpreadRadius
		{
			get
			{
				if (_movementSpreadRadius == null)
				{
					_movementSpreadRadius = (CFloat) CR2WTypeManager.Create("Float", "movementSpreadRadius", cr2w, this);
				}
				return _movementSpreadRadius;
			}
			set
			{
				if (_movementSpreadRadius == value)
				{
					return;
				}
				_movementSpreadRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("distanceToReactBack")] 
		public CFloat DistanceToReactBack
		{
			get
			{
				if (_distanceToReactBack == null)
				{
					_distanceToReactBack = (CFloat) CR2WTypeManager.Create("Float", "distanceToReactBack", cr2w, this);
				}
				return _distanceToReactBack;
			}
			set
			{
				if (_distanceToReactBack == value)
				{
					return;
				}
				_distanceToReactBack = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("distanceToReactFront")] 
		public CFloat DistanceToReactFront
		{
			get
			{
				if (_distanceToReactFront == null)
				{
					_distanceToReactFront = (CFloat) CR2WTypeManager.Create("Float", "distanceToReactFront", cr2w, this);
				}
				return _distanceToReactFront;
			}
			set
			{
				if (_distanceToReactFront == value)
				{
					return;
				}
				_distanceToReactFront = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("reactionSettings")] 
		public CArray<gameinfluenceBumpReactionSetting> ReactionSettings
		{
			get
			{
				if (_reactionSettings == null)
				{
					_reactionSettings = (CArray<gameinfluenceBumpReactionSetting>) CR2WTypeManager.Create("array:gameinfluenceBumpReactionSetting", "reactionSettings", cr2w, this);
				}
				return _reactionSettings;
			}
			set
			{
				if (_reactionSettings == value)
				{
					return;
				}
				_reactionSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("autoPlayBumpAnimation")] 
		public CBool AutoPlayBumpAnimation
		{
			get
			{
				if (_autoPlayBumpAnimation == null)
				{
					_autoPlayBumpAnimation = (CBool) CR2WTypeManager.Create("Bool", "autoPlayBumpAnimation", cr2w, this);
				}
				return _autoPlayBumpAnimation;
			}
			set
			{
				if (_autoPlayBumpAnimation == value)
				{
					return;
				}
				_autoPlayBumpAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isBumpable")] 
		public CBool IsBumpable
		{
			get
			{
				if (_isBumpable == null)
				{
					_isBumpable = (CBool) CR2WTypeManager.Create("Bool", "isBumpable", cr2w, this);
				}
				return _isBumpable;
			}
			set
			{
				if (_isBumpable == value)
				{
					return;
				}
				_isBumpable = value;
				PropertySet(this);
			}
		}

		public gameinfluenceBumpComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
