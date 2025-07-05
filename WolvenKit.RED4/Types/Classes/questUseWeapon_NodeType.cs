using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUseWeapon_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("usageType")] 
		public CEnum<questWeaponUsageType> UsageType
		{
			get => GetPropertyValue<CEnum<questWeaponUsageType>>();
			set => SetPropertyValue<CEnum<questWeaponUsageType>>(value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(2)] 
		[RED("overrideShootEffect")] 
		public CName OverrideShootEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("weaponSlotName")] 
		public CName WeaponSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questUseWeapon_NodeType()
		{
			WeaponSlotName = "AttachmentSlots.WeaponRight";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
