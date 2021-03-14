using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinData : gamemappinsIMappinData
	{
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinVariant> _variant;
		private CBool _active;
		private CString _debugCaption;
		private LocalizationString _localizedCaption;
		private CBool _visibleThroughWalls;
		private CHandle<gamemappinsMappinScriptData> _scriptData;

		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get
			{
				if (_mappinType == null)
				{
					_mappinType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mappinType", cr2w, this);
				}
				return _mappinType;
			}
			set
			{
				if (_mappinType == value)
				{
					return;
				}
				_mappinType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get
			{
				if (_variant == null)
				{
					_variant = (CEnum<gamedataMappinVariant>) CR2WTypeManager.Create("gamedataMappinVariant", "variant", cr2w, this);
				}
				return _variant;
			}
			set
			{
				if (_variant == value)
				{
					return;
				}
				_variant = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("debugCaption")] 
		public CString DebugCaption
		{
			get
			{
				if (_debugCaption == null)
				{
					_debugCaption = (CString) CR2WTypeManager.Create("String", "debugCaption", cr2w, this);
				}
				return _debugCaption;
			}
			set
			{
				if (_debugCaption == value)
				{
					return;
				}
				_debugCaption = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("localizedCaption")] 
		public LocalizationString LocalizedCaption
		{
			get
			{
				if (_localizedCaption == null)
				{
					_localizedCaption = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "localizedCaption", cr2w, this);
				}
				return _localizedCaption;
			}
			set
			{
				if (_localizedCaption == value)
				{
					return;
				}
				_localizedCaption = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get
			{
				if (_visibleThroughWalls == null)
				{
					_visibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "visibleThroughWalls", cr2w, this);
				}
				return _visibleThroughWalls;
			}
			set
			{
				if (_visibleThroughWalls == value)
				{
					return;
				}
				_visibleThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scriptData")] 
		public CHandle<gamemappinsMappinScriptData> ScriptData
		{
			get
			{
				if (_scriptData == null)
				{
					_scriptData = (CHandle<gamemappinsMappinScriptData>) CR2WTypeManager.Create("handle:gamemappinsMappinScriptData", "scriptData", cr2w, this);
				}
				return _scriptData;
			}
			set
			{
				if (_scriptData == value)
				{
					return;
				}
				_scriptData = value;
				PropertySet(this);
			}
		}

		public gamemappinsMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
