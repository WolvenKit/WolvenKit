using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectDefinition : CVariable
	{
		private CName _tag;
		private CArray<CHandle<gameEffectObjectProvider>> _objectProviders;
		private CArray<CHandle<gameEffectObjectFilter>> _objectFilters;
		private CArray<CHandle<gameEffectExecutor>> _effectExecutors;
		private CArray<CHandle<gameEffectDurationModifier>> _durationModifiers;
		private CArray<CHandle<gameEffectPreAction>> _preActions;
		private CArray<CHandle<gameEffectPostAction>> _postActions;
		private CArray<CHandle<gameEffectAction>> _noTargetsActions;
		private gameEffectSettings _settings;
		private gameEffectDebugSettings _debugSettings;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectProviders")] 
		public CArray<CHandle<gameEffectObjectProvider>> ObjectProviders
		{
			get
			{
				if (_objectProviders == null)
				{
					_objectProviders = (CArray<CHandle<gameEffectObjectProvider>>) CR2WTypeManager.Create("array:handle:gameEffectObjectProvider", "objectProviders", cr2w, this);
				}
				return _objectProviders;
			}
			set
			{
				if (_objectProviders == value)
				{
					return;
				}
				_objectProviders = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("objectFilters")] 
		public CArray<CHandle<gameEffectObjectFilter>> ObjectFilters
		{
			get
			{
				if (_objectFilters == null)
				{
					_objectFilters = (CArray<CHandle<gameEffectObjectFilter>>) CR2WTypeManager.Create("array:handle:gameEffectObjectFilter", "objectFilters", cr2w, this);
				}
				return _objectFilters;
			}
			set
			{
				if (_objectFilters == value)
				{
					return;
				}
				_objectFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("effectExecutors")] 
		public CArray<CHandle<gameEffectExecutor>> EffectExecutors
		{
			get
			{
				if (_effectExecutors == null)
				{
					_effectExecutors = (CArray<CHandle<gameEffectExecutor>>) CR2WTypeManager.Create("array:handle:gameEffectExecutor", "effectExecutors", cr2w, this);
				}
				return _effectExecutors;
			}
			set
			{
				if (_effectExecutors == value)
				{
					return;
				}
				_effectExecutors = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("durationModifiers")] 
		public CArray<CHandle<gameEffectDurationModifier>> DurationModifiers
		{
			get
			{
				if (_durationModifiers == null)
				{
					_durationModifiers = (CArray<CHandle<gameEffectDurationModifier>>) CR2WTypeManager.Create("array:handle:gameEffectDurationModifier", "durationModifiers", cr2w, this);
				}
				return _durationModifiers;
			}
			set
			{
				if (_durationModifiers == value)
				{
					return;
				}
				_durationModifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("preActions")] 
		public CArray<CHandle<gameEffectPreAction>> PreActions
		{
			get
			{
				if (_preActions == null)
				{
					_preActions = (CArray<CHandle<gameEffectPreAction>>) CR2WTypeManager.Create("array:handle:gameEffectPreAction", "preActions", cr2w, this);
				}
				return _preActions;
			}
			set
			{
				if (_preActions == value)
				{
					return;
				}
				_preActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("postActions")] 
		public CArray<CHandle<gameEffectPostAction>> PostActions
		{
			get
			{
				if (_postActions == null)
				{
					_postActions = (CArray<CHandle<gameEffectPostAction>>) CR2WTypeManager.Create("array:handle:gameEffectPostAction", "postActions", cr2w, this);
				}
				return _postActions;
			}
			set
			{
				if (_postActions == value)
				{
					return;
				}
				_postActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("noTargetsActions")] 
		public CArray<CHandle<gameEffectAction>> NoTargetsActions
		{
			get
			{
				if (_noTargetsActions == null)
				{
					_noTargetsActions = (CArray<CHandle<gameEffectAction>>) CR2WTypeManager.Create("array:handle:gameEffectAction", "noTargetsActions", cr2w, this);
				}
				return _noTargetsActions;
			}
			set
			{
				if (_noTargetsActions == value)
				{
					return;
				}
				_noTargetsActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("settings")] 
		public gameEffectSettings Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (gameEffectSettings) CR2WTypeManager.Create("gameEffectSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("debugSettings")] 
		public gameEffectDebugSettings DebugSettings
		{
			get
			{
				if (_debugSettings == null)
				{
					_debugSettings = (gameEffectDebugSettings) CR2WTypeManager.Create("gameEffectDebugSettings", "debugSettings", cr2w, this);
				}
				return _debugSettings;
			}
			set
			{
				if (_debugSettings == value)
				{
					return;
				}
				_debugSettings = value;
				PropertySet(this);
			}
		}

		public gameEffectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
