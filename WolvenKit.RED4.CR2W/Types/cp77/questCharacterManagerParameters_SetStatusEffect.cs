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
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		[Ordinal(3)] 
		[RED("isPlayerStatusEffectSource")] 
		public CBool IsPlayerStatusEffectSource
		{
			get => GetProperty(ref _isPlayerStatusEffectSource);
			set => SetProperty(ref _isPlayerStatusEffectSource, value);
		}

		[Ordinal(4)] 
		[RED("statusEffectSourceObject")] 
		public gameEntityReference StatusEffectSourceObject
		{
			get => GetProperty(ref _statusEffectSourceObject);
			set => SetProperty(ref _statusEffectSourceObject, value);
		}

		[Ordinal(5)] 
		[RED("recordSelector")] 
		public CHandle<questRecordSelector> RecordSelector
		{
			get => GetProperty(ref _recordSelector);
			set => SetProperty(ref _recordSelector, value);
		}

		[Ordinal(6)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		public questCharacterManagerParameters_SetStatusEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
