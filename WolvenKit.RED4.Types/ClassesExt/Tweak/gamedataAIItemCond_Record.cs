
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIItemCond_Record
	{
		[RED("checkAllItemsInEquipmentGroup")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckAllItemsInEquipmentGroup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("equipmentGroup")]
		[REDProperty(IsIgnored = true)]
		public CName EquipmentGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("evolution")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Evolution
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemTag")]
		[REDProperty(IsIgnored = true)]
		public CName ItemTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("itemType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("triggerModes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TriggerModes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
