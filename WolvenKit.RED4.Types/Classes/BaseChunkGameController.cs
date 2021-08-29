using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseChunkGameController : gameuiWidgetGameController
	{
		private CWeakHandle<gameIBlackboard> _chunkBlackboard;
		private CHandle<UI_ScannerModulesDef> _chunkBlackboardDef;
		private CHandle<UI_ScannerDef> _questClueBlackboardDef;

		[Ordinal(2)] 
		[RED("chunkBlackboard")] 
		public CWeakHandle<gameIBlackboard> ChunkBlackboard
		{
			get => GetProperty(ref _chunkBlackboard);
			set => SetProperty(ref _chunkBlackboard, value);
		}

		[Ordinal(3)] 
		[RED("chunkBlackboardDef")] 
		public CHandle<UI_ScannerModulesDef> ChunkBlackboardDef
		{
			get => GetProperty(ref _chunkBlackboardDef);
			set => SetProperty(ref _chunkBlackboardDef, value);
		}

		[Ordinal(4)] 
		[RED("questClueBlackboardDef")] 
		public CHandle<UI_ScannerDef> QuestClueBlackboardDef
		{
			get => GetProperty(ref _questClueBlackboardDef);
			set => SetProperty(ref _questClueBlackboardDef, value);
		}
	}
}
