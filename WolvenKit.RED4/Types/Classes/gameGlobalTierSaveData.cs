using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGlobalTierSaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CEnum<gameGlobalTierSubtype> Subtype
		{
			get => GetPropertyValue<CEnum<gameGlobalTierSubtype>>();
			set => SetPropertyValue<CEnum<gameGlobalTierSubtype>>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameSceneTierData> Data
		{
			get => GetPropertyValue<CHandle<gameSceneTierData>>();
			set => SetPropertyValue<CHandle<gameSceneTierData>>(value);
		}

		public gameGlobalTierSaveData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
