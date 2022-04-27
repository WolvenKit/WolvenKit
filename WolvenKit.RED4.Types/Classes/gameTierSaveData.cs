using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTierSaveData : ISerializable
	{
		[Ordinal(0)] 
		[RED("globalTiers")] 
		public CArray<gameGlobalTierSaveData> GlobalTiers
		{
			get => GetPropertyValue<CArray<gameGlobalTierSaveData>>();
			set => SetPropertyValue<CArray<gameGlobalTierSaveData>>(value);
		}

		public gameTierSaveData()
		{
			GlobalTiers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
