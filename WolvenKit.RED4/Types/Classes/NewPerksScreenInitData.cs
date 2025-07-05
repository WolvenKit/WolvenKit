using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksScreenInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("attribute")] 
		public TweakDBID Attribute
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("attributeData")] 
		public CWeakHandle<gamedataAttributeData_Record> AttributeData
		{
			get => GetPropertyValue<CWeakHandle<gamedataAttributeData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAttributeData_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("perkMenuAttribute")] 
		public CEnum<PerkMenuAttribute> PerkMenuAttribute
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(4)] 
		[RED("isPlayerInCombat")] 
		public CBool IsPlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewPerksScreenInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
