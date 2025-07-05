using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGodModeEntityData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<gameGodModeData> Overrides
		{
			get => GetPropertyValue<CArray<gameGodModeData>>();
			set => SetPropertyValue<CArray<gameGodModeData>>(value);
		}

		[Ordinal(1)] 
		[RED("base")] 
		public CArray<gameGodModeData> Base
		{
			get => GetPropertyValue<CArray<gameGodModeData>>();
			set => SetPropertyValue<CArray<gameGodModeData>>(value);
		}

		public gameGodModeEntityData()
		{
			Overrides = new();
			Base = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
