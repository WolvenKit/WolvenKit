using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntitySpawnerSlotData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("spawnableObject")] 
		public TweakDBID SpawnableObject
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameEntitySpawnerSlotData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
