using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Katana : gameweaponObject
	{
		[Ordinal(66)] 
		[RED("bentBulletTemplateName")] 
		public CName BentBulletTemplateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(67)] 
		[RED("bulletBendingReferenceSlotName")] 
		public CName BulletBendingReferenceSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(68)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(69)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		public Katana()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
