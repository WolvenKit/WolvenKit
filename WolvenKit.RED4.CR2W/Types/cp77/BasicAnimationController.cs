using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicAnimationController : inkWidgetLogicController
	{
		private CName _showAnimation;
		private CName _idleAnimation;
		private CName _hideAnimation;
		private CHandle<AnimationChainPlayer> _animationPlayer;
		private CName _currentAnimation;

		[Ordinal(1)] 
		[RED("showAnimation")] 
		public CName ShowAnimation
		{
			get
			{
				if (_showAnimation == null)
				{
					_showAnimation = (CName) CR2WTypeManager.Create("CName", "showAnimation", cr2w, this);
				}
				return _showAnimation;
			}
			set
			{
				if (_showAnimation == value)
				{
					return;
				}
				_showAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("idleAnimation")] 
		public CName IdleAnimation
		{
			get
			{
				if (_idleAnimation == null)
				{
					_idleAnimation = (CName) CR2WTypeManager.Create("CName", "idleAnimation", cr2w, this);
				}
				return _idleAnimation;
			}
			set
			{
				if (_idleAnimation == value)
				{
					return;
				}
				_idleAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hideAnimation")] 
		public CName HideAnimation
		{
			get
			{
				if (_hideAnimation == null)
				{
					_hideAnimation = (CName) CR2WTypeManager.Create("CName", "hideAnimation", cr2w, this);
				}
				return _hideAnimation;
			}
			set
			{
				if (_hideAnimation == value)
				{
					return;
				}
				_hideAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animationPlayer")] 
		public CHandle<AnimationChainPlayer> AnimationPlayer
		{
			get
			{
				if (_animationPlayer == null)
				{
					_animationPlayer = (CHandle<AnimationChainPlayer>) CR2WTypeManager.Create("handle:AnimationChainPlayer", "animationPlayer", cr2w, this);
				}
				return _animationPlayer;
			}
			set
			{
				if (_animationPlayer == value)
				{
					return;
				}
				_animationPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentAnimation")] 
		public CName CurrentAnimation
		{
			get
			{
				if (_currentAnimation == null)
				{
					_currentAnimation = (CName) CR2WTypeManager.Create("CName", "currentAnimation", cr2w, this);
				}
				return _currentAnimation;
			}
			set
			{
				if (_currentAnimation == value)
				{
					return;
				}
				_currentAnimation = value;
				PropertySet(this);
			}
		}

		public BasicAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
