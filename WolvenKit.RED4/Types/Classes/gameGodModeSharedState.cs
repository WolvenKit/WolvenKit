using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGodModeSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("datas")] 
		public CArray<gameGodModeSharedStateData> Datas
		{
			get => GetPropertyValue<CArray<gameGodModeSharedStateData>>();
			set => SetPropertyValue<CArray<gameGodModeSharedStateData>>(value);
		}

		public gameGodModeSharedState()
		{
			Datas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
