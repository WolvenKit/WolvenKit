using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetStatusEffect : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private TweakDBID _statusEffectID;
		private CBool _isPlayerStatusEffectSource;
		private gameEntityReference _statusEffectSourceObject;
		private CHandle<questRecordSelector> _recordSelector;
		private CBool _set;

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
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get
			{
				if (_statusEffectID == null)
				{
					_statusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectID", cr2w, this);
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
		[RED("isPlayerStatusEffectSource")] 
		public CBool IsPlayerStatusEffectSource
		{
			get
			{
				if (_isPlayerStatusEffectSource == null)
				{
					_isPlayerStatusEffectSource = (CBool) CR2WTypeManager.Create("Bool", "isPlayerStatusEffectSource", cr2w, this);
				}
				return _isPlayerStatusEffectSource;
			}
			set
			{
				if (_isPlayerStatusEffectSource == value)
				{
					return;
				}
				_isPlayerStatusEffectSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statusEffectSourceObject")] 
		public gameEntityReference StatusEffectSourceObject
		{
			get
			{
				if (_statusEffectSourceObject == null)
				{
					_statusEffectSourceObject = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "statusEffectSourceObject", cr2w, this);
				}
				return _statusEffectSourceObject;
			}
			set
			{
				if (_statusEffectSourceObject == value)
				{
					return;
				}
				_statusEffectSourceObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("recordSelector")] 
		public CHandle<questRecordSelector> RecordSelector
		{
			get
			{
				if (_recordSelector == null)
				{
					_recordSelector = (CHandle<questRecordSelector>) CR2WTypeManager.Create("handle:questRecordSelector", "recordSelector", cr2w, this);
				}
				return _recordSelector;
			}
			set
			{
				if (_recordSelector == value)
				{
					return;
				}
				_recordSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("set")] 
		public CBool Set
		{
			get
			{
				if (_set == null)
				{
					_set = (CBool) CR2WTypeManager.Create("Bool", "set", cr2w, this);
				}
				return _set;
			}
			set
			{
				if (_set == value)
				{
					return;
				}
				_set = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_SetStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
