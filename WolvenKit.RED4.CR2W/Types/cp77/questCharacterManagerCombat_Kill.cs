using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_Kill : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _noAnimation;
		private CBool _noRagdoll;
		private CBool _skipDefeatedState;
		private CBool _doDismemberment;
		private CEnum<physicsRagdollBodyPartE> _bodyPart;
		private CEnum<entdismembermentWoundTypeE> _woundType;
		private CFloat _dismembermentStrenght;

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
		[RED("noAnimation")] 
		public CBool NoAnimation
		{
			get
			{
				if (_noAnimation == null)
				{
					_noAnimation = (CBool) CR2WTypeManager.Create("Bool", "noAnimation", cr2w, this);
				}
				return _noAnimation;
			}
			set
			{
				if (_noAnimation == value)
				{
					return;
				}
				_noAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("noRagdoll")] 
		public CBool NoRagdoll
		{
			get
			{
				if (_noRagdoll == null)
				{
					_noRagdoll = (CBool) CR2WTypeManager.Create("Bool", "noRagdoll", cr2w, this);
				}
				return _noRagdoll;
			}
			set
			{
				if (_noRagdoll == value)
				{
					return;
				}
				_noRagdoll = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("skipDefeatedState")] 
		public CBool SkipDefeatedState
		{
			get
			{
				if (_skipDefeatedState == null)
				{
					_skipDefeatedState = (CBool) CR2WTypeManager.Create("Bool", "skipDefeatedState", cr2w, this);
				}
				return _skipDefeatedState;
			}
			set
			{
				if (_skipDefeatedState == value)
				{
					return;
				}
				_skipDefeatedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("doDismemberment")] 
		public CBool DoDismemberment
		{
			get
			{
				if (_doDismemberment == null)
				{
					_doDismemberment = (CBool) CR2WTypeManager.Create("Bool", "doDismemberment", cr2w, this);
				}
				return _doDismemberment;
			}
			set
			{
				if (_doDismemberment == value)
				{
					return;
				}
				_doDismemberment = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bodyPart")] 
		public CEnum<physicsRagdollBodyPartE> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("woundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CEnum<entdismembermentWoundTypeE>) CR2WTypeManager.Create("entdismembermentWoundTypeE", "woundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("dismembermentStrenght")] 
		public CFloat DismembermentStrenght
		{
			get
			{
				if (_dismembermentStrenght == null)
				{
					_dismembermentStrenght = (CFloat) CR2WTypeManager.Create("Float", "dismembermentStrenght", cr2w, this);
				}
				return _dismembermentStrenght;
			}
			set
			{
				if (_dismembermentStrenght == value)
				{
					return;
				}
				_dismembermentStrenght = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_Kill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
