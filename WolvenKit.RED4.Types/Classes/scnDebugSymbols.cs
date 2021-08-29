using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnDebugSymbols : RedBaseClass
	{
		private CArray<scnPerformerSymbol> _performersDebugSymbols;
		private CArray<scnWorkspotSymbol> _workspotsDebugSymbols;
		private CArray<scnSceneEventSymbol> _sceneEventsDebugSymbols;
		private CArray<scnNodeSymbol> _sceneNodesDebugSymbols;

		[Ordinal(0)] 
		[RED("performersDebugSymbols")] 
		public CArray<scnPerformerSymbol> PerformersDebugSymbols
		{
			get => GetProperty(ref _performersDebugSymbols);
			set => SetProperty(ref _performersDebugSymbols, value);
		}

		[Ordinal(1)] 
		[RED("workspotsDebugSymbols")] 
		public CArray<scnWorkspotSymbol> WorkspotsDebugSymbols
		{
			get => GetProperty(ref _workspotsDebugSymbols);
			set => SetProperty(ref _workspotsDebugSymbols, value);
		}

		[Ordinal(2)] 
		[RED("sceneEventsDebugSymbols")] 
		public CArray<scnSceneEventSymbol> SceneEventsDebugSymbols
		{
			get => GetProperty(ref _sceneEventsDebugSymbols);
			set => SetProperty(ref _sceneEventsDebugSymbols, value);
		}

		[Ordinal(3)] 
		[RED("sceneNodesDebugSymbols")] 
		public CArray<scnNodeSymbol> SceneNodesDebugSymbols
		{
			get => GetProperty(ref _sceneNodesDebugSymbols);
			set => SetProperty(ref _sceneNodesDebugSymbols, value);
		}
	}
}
