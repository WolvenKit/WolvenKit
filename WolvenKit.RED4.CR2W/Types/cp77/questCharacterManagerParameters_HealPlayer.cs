using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_HealPlayer : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _heal;
		private CBool _removeStatusEffects;
		private CBool _removeBuffs;
		private CBool _removeDebuffs;
		private CBool _resetCyberdeckRAM;

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
		[RED("heal")] 
		public CBool Heal
		{
			get
			{
				if (_heal == null)
				{
					_heal = (CBool) CR2WTypeManager.Create("Bool", "heal", cr2w, this);
				}
				return _heal;
			}
			set
			{
				if (_heal == value)
				{
					return;
				}
				_heal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("removeStatusEffects")] 
		public CBool RemoveStatusEffects
		{
			get
			{
				if (_removeStatusEffects == null)
				{
					_removeStatusEffects = (CBool) CR2WTypeManager.Create("Bool", "removeStatusEffects", cr2w, this);
				}
				return _removeStatusEffects;
			}
			set
			{
				if (_removeStatusEffects == value)
				{
					return;
				}
				_removeStatusEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("removeBuffs")] 
		public CBool RemoveBuffs
		{
			get
			{
				if (_removeBuffs == null)
				{
					_removeBuffs = (CBool) CR2WTypeManager.Create("Bool", "removeBuffs", cr2w, this);
				}
				return _removeBuffs;
			}
			set
			{
				if (_removeBuffs == value)
				{
					return;
				}
				_removeBuffs = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("removeDebuffs")] 
		public CBool RemoveDebuffs
		{
			get
			{
				if (_removeDebuffs == null)
				{
					_removeDebuffs = (CBool) CR2WTypeManager.Create("Bool", "removeDebuffs", cr2w, this);
				}
				return _removeDebuffs;
			}
			set
			{
				if (_removeDebuffs == value)
				{
					return;
				}
				_removeDebuffs = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("resetCyberdeckRAM")] 
		public CBool ResetCyberdeckRAM
		{
			get
			{
				if (_resetCyberdeckRAM == null)
				{
					_resetCyberdeckRAM = (CBool) CR2WTypeManager.Create("Bool", "resetCyberdeckRAM", cr2w, this);
				}
				return _resetCyberdeckRAM;
			}
			set
			{
				if (_resetCyberdeckRAM == value)
				{
					return;
				}
				_resetCyberdeckRAM = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_HealPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
