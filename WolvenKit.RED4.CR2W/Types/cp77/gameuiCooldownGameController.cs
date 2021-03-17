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
			get => GetProperty(ref _maxCooldowns);
			set => SetProperty(ref _maxCooldowns, value);
		}

		[Ordinal(3)] 
		[RED("cooldownContainer")] 
		public inkCompoundWidgetReference CooldownContainer
		{
			get => GetProperty(ref _cooldownContainer);
			set => SetProperty(ref _cooldownContainer, value);
		}

		[Ordinal(4)] 
		[RED("poolHolder")] 
		public inkCompoundWidgetReference PoolHolder
		{
			get => GetProperty(ref _poolHolder);
			set => SetProperty(ref _poolHolder, value);
		}

		[Ordinal(5)] 
		[RED("mode")] 
		public CEnum<ECooldownGameControllerMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(6)] 
		[RED("effectTypes")] 
		public CArray<CEnum<gamedataStatusEffectType>> EffectTypes
		{
			get => GetProperty(ref _effectTypes);
			set => SetProperty(ref _effectTypes, value);
		}

		[Ordinal(7)] 
		[RED("cooldownPool")] 
		public CArray<CHandle<SingleCooldownManager>> CooldownPool
		{
			get => GetProperty(ref _cooldownPool);
			set => SetProperty(ref _cooldownPool, value);
		}

		[Ordinal(8)] 
		[RED("matchBuffer")] 
		public CArray<CHandle<SingleCooldownManager>> MatchBuffer
		{
			get => GetProperty(ref _matchBuffer);
			set => SetProperty(ref _matchBuffer, value);
		}

		[Ordinal(9)] 
		[RED("buffsCallback")] 
		public CUInt32 BuffsCallback
		{
			get => GetProperty(ref _buffsCallback);
			set => SetProperty(ref _buffsCallback, value);
		}

		[Ordinal(10)] 
		[RED("debuffsCallback")] 
		public CUInt32 DebuffsCallback
		{
			get => GetProperty(ref _debuffsCallback);
			set => SetProperty(ref _debuffsCallback, value);
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_PlayerBioMonitorDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(12)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public gameuiCooldownGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
