using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterStatusEffect_CondtionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CString _statusEffectID;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
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
		[RED("statusEffectID")] 
		public CString StatusEffectID
		{
			get
			{
				if (_statusEffectID == null)
				{
					_statusEffectID = (CString) CR2WTypeManager.Create("String", "statusEffectID", cr2w, this);
				}
				return _statusEffectID;
			}
			set
			{
				if (_statusEffectID == value)
				{
					return;
				}
				_statusEffectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questCharacterStatusEffect_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
