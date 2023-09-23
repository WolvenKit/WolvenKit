using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RelicPerkSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("registeredPerkDevices")] 
		public CArray<CHandle<PerkDeviceMappinData>> RegisteredPerkDevices
		{
			get => GetPropertyValue<CArray<CHandle<PerkDeviceMappinData>>>();
			set => SetPropertyValue<CArray<CHandle<PerkDeviceMappinData>>>(value);
		}

		public RelicPerkSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
