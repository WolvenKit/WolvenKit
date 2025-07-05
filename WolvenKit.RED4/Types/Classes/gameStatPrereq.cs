using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatPrereq : gameIRPGPrereq
	{
		[Ordinal(1)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(2)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameStatPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
