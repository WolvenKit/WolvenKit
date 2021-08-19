using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCooldown : CVariable
	{
		private gameDelayID _delayId;
		private gameDelayID _removeId;
		private CInt32 _cid;
		private CName _cdName;
		private wCHandle<entEntity> _owner;
		private gameItemID _ownerItemID;
		private TweakDBID _ownerRecord;
		private CFloat _duration;
		private CEnum<gamedataStatType> _type;
		private CFloat _durationMultiplier;
		private CBool _modifiable;
		private CBool _affectedByTimeDilation;
		private CEnum<gamedataStatType> _abilityType;
		private CHandle<gameStatModifierData_Deprecated> _statMod;

		[Ordinal(0)] 
		[RED("delayId")] 
		public gameDelayID DelayId
		{
			get => GetProperty(ref _delayId);
			set => SetProperty(ref _delayId, value);
		}

		[Ordinal(1)] 
		[RED("removeId")] 
		public gameDelayID RemoveId
		{
			get => GetProperty(ref _removeId);
			set => SetProperty(ref _removeId, value);
		}

		[Ordinal(2)] 
		[RED("cid")] 
		public CInt32 Cid
		{
			get => GetProperty(ref _cid);
			set => SetProperty(ref _cid, value);
		}

		[Ordinal(3)] 
		[RED("cdName")] 
		public CName CdName
		{
			get => GetProperty(ref _cdName);
			set => SetProperty(ref _cdName, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(5)] 
		[RED("ownerItemID")] 
		public gameItemID OwnerItemID
		{
			get => GetProperty(ref _ownerItemID);
			set => SetProperty(ref _ownerItemID, value);
		}

		[Ordinal(6)] 
		[RED("ownerRecord")] 
		public TweakDBID OwnerRecord
		{
			get => GetProperty(ref _ownerRecord);
			set => SetProperty(ref _ownerRecord, value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(8)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(9)] 
		[RED("durationMultiplier")] 
		public CFloat DurationMultiplier
		{
			get => GetProperty(ref _durationMultiplier);
			set => SetProperty(ref _durationMultiplier, value);
		}

		[Ordinal(10)] 
		[RED("modifiable")] 
		public CBool Modifiable
		{
			get => GetProperty(ref _modifiable);
			set => SetProperty(ref _modifiable, value);
		}

		[Ordinal(11)] 
		[RED("affectedByTimeDilation")] 
		public CBool AffectedByTimeDilation
		{
			get => GetProperty(ref _affectedByTimeDilation);
			set => SetProperty(ref _affectedByTimeDilation, value);
		}

		[Ordinal(12)] 
		[RED("abilityType")] 
		public CEnum<gamedataStatType> AbilityType
		{
			get => GetProperty(ref _abilityType);
			set => SetProperty(ref _abilityType, value);
		}

		[Ordinal(13)] 
		[RED("statMod")] 
		public CHandle<gameStatModifierData_Deprecated> StatMod
		{
			get => GetProperty(ref _statMod);
			set => SetProperty(ref _statMod, value);
		}

		public SCooldown(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
