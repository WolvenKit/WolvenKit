using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatPoolsSystemSave : ISerializable
	{
		[Ordinal(0)] 
		[RED("mapping")] 
		public CArray<gameStatsObjectID> Mapping
		{
			get => GetPropertyValue<CArray<gameStatsObjectID>>();
			set => SetPropertyValue<CArray<gameStatsObjectID>>(value);
		}

		[Ordinal(1)] 
		[RED("statPools")] 
		public CArray<gameStatPoolData> StatPools
		{
			get => GetPropertyValue<CArray<gameStatPoolData>>();
			set => SetPropertyValue<CArray<gameStatPoolData>>(value);
		}

		public gameStatPoolsSystemSave()
		{
			Mapping = new();
			StatPools = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
