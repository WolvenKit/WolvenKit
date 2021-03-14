using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCooldownGameController : gameuiWidgetGameController
	{
		private CInt32 _maxCooldowns;
		private inkCompoundWidgetReference _cooldownContainer;
		private inkCompoundWidgetReference _poolHolder;
		private CEnum<ECooldownGameControllerMode> _mode;
		private CArray<CEnum<gamedataStatusEffectType>> _effectTypes;
		private CArray<CHandle<SingleCooldownManager>> _cooldownPool;
		private CArray<CHandle<SingleCooldownManager>> _matchBuffer;
		private CUInt32 _buffsCallback;
		private CUInt32 _debuffsCallback;
		private CHandle<UI_PlayerBioMonitorDef> _blackboardDef;
		private CHandle<gameIBlackboard> _blackboard;

		[Ordinal(2)] 
		[RED("maxCooldowns")] 
		public CInt32 MaxCooldowns
		{
			get
			{
				if (_maxCooldowns == null)
				{
					_maxCooldowns = (CInt32) CR2WTypeManager.Create("Int32", "maxCooldowns", cr2w, this);
				}
				return _maxCooldowns;
			}
			set
			{
				if (_maxCooldowns == value)
				{
					return;
				}
				_maxCooldowns = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cooldownContainer")] 
		public inkCompoundWidgetReference CooldownContainer
		{
			get
			{
				if (_cooldownContainer == null)
				{
					_cooldownContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "cooldownContainer", cr2w, this);
				}
				return _cooldownContainer;
			}
			set
			{
				if (_cooldownContainer == value)
				{
					return;
				}
				_cooldownContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("poolHolder")] 
		public inkCompoundWidgetReference PoolHolder
		{
			get
			{
				if (_poolHolder == null)
				{
					_poolHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "poolHolder", cr2w, this);
				}
				return _poolHolder;
			}
			set
			{
				if (_poolHolder == value)
				{
					return;
				}
				_poolHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mode")] 
		public CEnum<ECooldownGameControllerMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<ECooldownGameControllerMode>) CR2WTypeManager.Create("ECooldownGameControllerMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("effectTypes")] 
		public CArray<CEnum<gamedataStatusEffectType>> EffectTypes
		{
			get
			{
				if (_effectTypes == null)
				{
					_effectTypes = (CArray<CEnum<gamedataStatusEffectType>>) CR2WTypeManager.Create("array:gamedataStatusEffectType", "effectTypes", cr2w, this);
				}
				return _effectTypes;
			}
			set
			{
				if (_effectTypes == value)
				{
					return;
				}
				_effectTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cooldownPool")] 
		public CArray<CHandle<SingleCooldownManager>> CooldownPool
		{
			get
			{
				if (_cooldownPool == null)
				{
					_cooldownPool = (CArray<CHandle<SingleCooldownManager>>) CR2WTypeManager.Create("array:handle:SingleCooldownManager", "cooldownPool", cr2w, this);
				}
				return _cooldownPool;
			}
			set
			{
				if (_cooldownPool == value)
				{
					return;
				}
				_cooldownPool = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("matchBuffer")] 
		public CArray<CHandle<SingleCooldownManager>> MatchBuffer
		{
			get
			{
				if (_matchBuffer == null)
				{
					_matchBuffer = (CArray<CHandle<SingleCooldownManager>>) CR2WTypeManager.Create("array:handle:SingleCooldownManager", "matchBuffer", cr2w, this);
				}
				return _matchBuffer;
			}
			set
			{
				if (_matchBuffer == value)
				{
					return;
				}
				_matchBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("buffsCallback")] 
		public CUInt32 BuffsCallback
		{
			get
			{
				if (_buffsCallback == null)
				{
					_buffsCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "buffsCallback", cr2w, this);
				}
				return _buffsCallback;
			}
			set
			{
				if (_buffsCallback == value)
				{
					return;
				}
				_buffsCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("debuffsCallback")] 
		public CUInt32 DebuffsCallback
		{
			get
			{
				if (_debuffsCallback == null)
				{
					_debuffsCallback = (CUInt32) CR2WTypeManager.Create("Uint32", "debuffsCallback", cr2w, this);
				}
				return _debuffsCallback;
			}
			set
			{
				if (_debuffsCallback == value)
				{
					return;
				}
				_debuffsCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_PlayerBioMonitorDef> BlackboardDef
		{
			get
			{
				if (_blackboardDef == null)
				{
					_blackboardDef = (CHandle<UI_PlayerBioMonitorDef>) CR2WTypeManager.Create("handle:UI_PlayerBioMonitorDef", "blackboardDef", cr2w, this);
				}
				return _blackboardDef;
			}
			set
			{
				if (_blackboardDef == value)
				{
					return;
				}
				_blackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		public gameuiCooldownGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
