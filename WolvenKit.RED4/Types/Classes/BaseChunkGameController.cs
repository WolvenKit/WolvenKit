using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseChunkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("chunkBlackboard")] 
		public CWeakHandle<gameIBlackboard> ChunkBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("chunkBlackboardDef")] 
		public CHandle<UI_ScannerModulesDef> ChunkBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_ScannerModulesDef>>();
			set => SetPropertyValue<CHandle<UI_ScannerModulesDef>>(value);
		}

		[Ordinal(4)] 
		[RED("questClueBlackboardDef")] 
		public CHandle<UI_ScannerDef> QuestClueBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_ScannerDef>>();
			set => SetPropertyValue<CHandle<UI_ScannerDef>>(value);
		}

		public BaseChunkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
