using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TankTurretComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("attackRecord")] 
		public TweakDBID AttackRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("slotComponentName1")] 
		public CName SlotComponentName1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("slotName1")] 
		public CName SlotName1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("slotComponentName2")] 
		public CName SlotComponentName2
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("slotName2")] 
		public CName SlotName2
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("slotComponent1")] 
		public CHandle<entSlotComponent> SlotComponent1
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(11)] 
		[RED("slotComponent2")] 
		public CHandle<entSlotComponent> SlotComponent2
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		public TankTurretComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
