using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetMortality : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CEnum<gameGodModeType> _state;
		private CBool _resetToDefault;
		private CName _source;

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
		[RED("state")] 
		public CEnum<gameGodModeType> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameGodModeType>) CR2WTypeManager.Create("gameGodModeType", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get
			{
				if (_resetToDefault == null)
				{
					_resetToDefault = (CBool) CR2WTypeManager.Create("Bool", "resetToDefault", cr2w, this);
				}
				return _resetToDefault;
			}
			set
			{
				if (_resetToDefault == value)
				{
					return;
				}
				_resetToDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_SetMortality(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
