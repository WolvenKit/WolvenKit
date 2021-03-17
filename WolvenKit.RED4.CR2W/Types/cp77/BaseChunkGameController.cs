using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseChunkGameController : gameuiWidgetGameController
	{
		private CHandle<gameIBlackboard> _chunkBlackboard;
		private CHandle<UI_ScannerModulesDef> _chunkBlackboardDef;
		private CHandle<UI_ScannerDef> _questClueBlackboardDef;

		[Ordinal(2)] 
		[RED("chunkBlackboard")] 
		public CHandle<gameIBlackboard> ChunkBlackboard
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

		public BaseChunkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
