using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ModifyHealth : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CFloat _percent;
		private CBool _setExactValue;
		private CBool _noDamageIndicator;
		private gameEntityReference _damageSourceRef;

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
		[RED("percent")] 
		public CFloat Percent
		{
			get
			{
				if (_percent == null)
				{
					_percent = (CFloat) CR2WTypeManager.Create("Float", "percent", cr2w, this);
				}
				return _percent;
			}
			set
			{
				if (_percent == value)
				{
					return;
				}
				_percent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("setExactValue")] 
		public CBool SetExactValue
		{
			get
			{
				if (_setExactValue == null)
				{
					_setExactValue = (CBool) CR2WTypeManager.Create("Bool", "setExactValue", cr2w, this);
				}
				return _setExactValue;
			}
			set
			{
				if (_setExactValue == value)
				{
					return;
				}
				_setExactValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("noDamageIndicator")] 
		public CBool NoDamageIndicator
		{
			get
			{
				if (_noDamageIndicator == null)
				{
					_noDamageIndicator = (CBool) CR2WTypeManager.Create("Bool", "noDamageIndicator", cr2w, this);
				}
				return _noDamageIndicator;
			}
			set
			{
				if (_noDamageIndicator == value)
				{
					return;
				}
				_noDamageIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("damageSourceRef")] 
		public gameEntityReference DamageSourceRef
		{
			get
			{
				if (_damageSourceRef == null)
				{
					_damageSourceRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "damageSourceRef", cr2w, this);
				}
				return _damageSourceRef;
			}
			set
			{
				if (_damageSourceRef == value)
				{
					return;
				}
				_damageSourceRef = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_ModifyHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
