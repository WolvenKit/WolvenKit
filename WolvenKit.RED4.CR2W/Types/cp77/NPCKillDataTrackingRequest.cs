using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCKillDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<EDownedType> _eventType;
		private DamageHistoryEntry _damageEntry;
		private CBool _isDownedRecorded;

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<EDownedType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		[Ordinal(2)] 
		[RED("damageEntry")] 
		public DamageHistoryEntry DamageEntry
		{
			get => GetProperty(ref _damageEntry);
			set => SetProperty(ref _damageEntry, value);
		}

		[Ordinal(3)] 
		[RED("isDownedRecorded")] 
		public CBool IsDownedRecorded
		{
			get => GetProperty(ref _isDownedRecorded);
			set => SetProperty(ref _isDownedRecorded, value);
		}

		public NPCKillDataTrackingRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
