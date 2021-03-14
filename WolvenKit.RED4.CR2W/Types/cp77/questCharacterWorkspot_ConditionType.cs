using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterWorkspot_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private NodeRef _spotRef;
		private CName _animationName;
		private CBool _waitForAnimEnd;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spotRef")] 
		public NodeRef SpotRef
		{
			get
			{
				if (_spotRef == null)
				{
					_spotRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "spotRef", cr2w, this);
				}
				return _spotRef;
			}
			set
			{
				if (_spotRef == value)
				{
					return;
				}
				_spotRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("waitForAnimEnd")] 
		public CBool WaitForAnimEnd
		{
			get
			{
				if (_waitForAnimEnd == null)
				{
					_waitForAnimEnd = (CBool) CR2WTypeManager.Create("Bool", "waitForAnimEnd", cr2w, this);
				}
				return _waitForAnimEnd;
			}
			set
			{
				if (_waitForAnimEnd == value)
				{
					return;
				}
				_waitForAnimEnd = value;
				PropertySet(this);
			}
		}

		public questCharacterWorkspot_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
