using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRegisterNewAbilityCooldownRequest : CVariable
	{
		private wCHandle<entEntity> _owner;
		private gameItemID _ownerItemId;
		private TweakDBID _ownerRecord;
		private CName _cooldownName;
		private CFloat _duration;
		private CEnum<gamedataStatType> _type;
		private CBool _modifiable;
		private CEnum<gamedataStatType> _abilityType;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("ownerItemId")] 
		public gameItemID OwnerItemId
		{
			get => GetProperty(ref _ownerItemId);
			set => SetProperty(ref _ownerItemId, value);
		}

		[Ordinal(2)] 
		[RED("ownerRecord")] 
		public TweakDBID OwnerRecord
		{
			get => GetProperty(ref _ownerRecord);
			set => SetProperty(ref _ownerRecord, value);
		}

		[Ordinal(3)] 
		[RED("cooldownName")] 
		public CName CooldownName
		{
			get => GetProperty(ref _cooldownName);
			set => SetProperty(ref _cooldownName, value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(6)] 
		[RED("modifiable")] 
		public CBool Modifiable
		{
			get => GetProperty(ref _modifiable);
			set => SetProperty(ref _modifiable, value);
		}

		[Ordinal(7)] 
		[RED("abilityType")] 
		public CEnum<gamedataStatType> AbilityType
		{
			get => GetProperty(ref _abilityType);
			set => SetProperty(ref _abilityType, value);
		}

		public gameRegisterNewAbilityCooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
