using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDebugCheatsSharedState : gameIGameSystemReplicatedState
	{
		private CArray<gamecheatsystemObjCheats> _activeCheats;
		private CUInt32 _debugTimeDilationIndex;
		private CUInt32 _debugTimeDilationPlayerIndex;

		[Ordinal(0)] 
		[RED("activeCheats")] 
		public CArray<gamecheatsystemObjCheats> ActiveCheats
		{
			get => GetProperty(ref _activeCheats);
			set => SetProperty(ref _activeCheats, value);
		}

		[Ordinal(1)] 
		[RED("debugTimeDilationIndex")] 
		public CUInt32 DebugTimeDilationIndex
		{
			get => GetProperty(ref _debugTimeDilationIndex);
			set => SetProperty(ref _debugTimeDilationIndex, value);
		}

		[Ordinal(2)] 
		[RED("debugTimeDilationPlayerIndex")] 
		public CUInt32 DebugTimeDilationPlayerIndex
		{
			get => GetProperty(ref _debugTimeDilationPlayerIndex);
			set => SetProperty(ref _debugTimeDilationPlayerIndex, value);
		}
	}
}
