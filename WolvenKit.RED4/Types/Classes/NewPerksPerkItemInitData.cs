using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksPerkItemInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("perkRecord")] 
		public CWeakHandle<gamedataNewPerk_Record> PerkRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataNewPerk_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataNewPerk_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(2)] 
		[RED("requiredAttributePoints")] 
		public CInt32 RequiredAttributePoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("isAttributeRequirementMet")] 
		public CBool IsAttributeRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("maxPerkLevel")] 
		public CInt32 MaxPerkLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("binkRef")] 
		public redResourceReferenceScriptToken BinkRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(7)] 
		[RED("category")] 
		public CEnum<gamedataNewPerkCategoryType> Category
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkCategoryType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkCategoryType>>(value);
		}

		[Ordinal(8)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public NewPerksPerkItemInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
