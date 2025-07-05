using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDebugCheatsSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("activeCheats")] 
		public CArray<gamecheatsystemObjCheats> ActiveCheats
		{
			get => GetPropertyValue<CArray<gamecheatsystemObjCheats>>();
			set => SetPropertyValue<CArray<gamecheatsystemObjCheats>>(value);
		}

		[Ordinal(1)] 
		[RED("debugTimeDilationIndex")] 
		public CUInt32 DebugTimeDilationIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("debugTimeDilationPlayerIndex")] 
		public CUInt32 DebugTimeDilationPlayerIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameDebugCheatsSharedState()
		{
			ActiveCheats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
