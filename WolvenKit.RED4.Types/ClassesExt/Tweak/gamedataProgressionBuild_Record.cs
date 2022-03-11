
namespace WolvenKit.RED4.Types
{
	public partial class gamedataProgressionBuild_Record
	{
		[RED("attributeSet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttributeSet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("craftBook")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CraftBook
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("cyberwareSet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CyberwareSet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("equipmentSet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EquipmentSet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("inventoryLayout")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> InventoryLayout
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("inventorySet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID InventorySet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("lifePath")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LifePath
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("perkSet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PerkSet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("perkSets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PerkSets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("proficiencySet")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ProficiencySet
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("randomizeClothing")]
		[REDProperty(IsIgnored = true)]
		public CBool RandomizeClothing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("startingAttributes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingAttributes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startingCyberware")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingCyberware
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startingEquipment")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingEquipment
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startingItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startingPerks")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingPerks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startingProficiencies")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingProficiencies
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
