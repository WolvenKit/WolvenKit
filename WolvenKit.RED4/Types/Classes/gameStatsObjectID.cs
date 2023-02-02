using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatsObjectID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("idType")] 
		public CEnum<gameStatIDType> IdType
		{
			get => GetPropertyValue<CEnum<gameStatIDType>>();
			set => SetPropertyValue<CEnum<gameStatIDType>>(value);
		}

		public gameStatsObjectID()
		{
			IdType = Enums.gameStatIDType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
