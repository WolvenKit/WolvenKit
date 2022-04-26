using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoachRaceDynObjectLogic : gameuiSideScrollerMiniGameDynObjectLogic
	{
		[Ordinal(2)] 
		[RED("minSpawnY")] 
		public CFloat MinSpawnY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxSpawnY")] 
		public CFloat MaxSpawnY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("extraSpeed")] 
		public CFloat ExtraSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("availableY")] 
		public CArray<CFloat> AvailableY
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public gameuiRoachRaceDynObjectLogic()
		{
			AvailableY = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
