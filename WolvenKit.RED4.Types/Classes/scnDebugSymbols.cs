using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDebugSymbols : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performersDebugSymbols")] 
		public CArray<scnPerformerSymbol> PerformersDebugSymbols
		{
			get => GetPropertyValue<CArray<scnPerformerSymbol>>();
			set => SetPropertyValue<CArray<scnPerformerSymbol>>(value);
		}

		[Ordinal(1)] 
		[RED("workspotsDebugSymbols")] 
		public CArray<scnWorkspotSymbol> WorkspotsDebugSymbols
		{
			get => GetPropertyValue<CArray<scnWorkspotSymbol>>();
			set => SetPropertyValue<CArray<scnWorkspotSymbol>>(value);
		}

		[Ordinal(2)] 
		[RED("sceneEventsDebugSymbols")] 
		public CArray<scnSceneEventSymbol> SceneEventsDebugSymbols
		{
			get => GetPropertyValue<CArray<scnSceneEventSymbol>>();
			set => SetPropertyValue<CArray<scnSceneEventSymbol>>(value);
		}

		[Ordinal(3)] 
		[RED("sceneNodesDebugSymbols")] 
		public CArray<scnNodeSymbol> SceneNodesDebugSymbols
		{
			get => GetPropertyValue<CArray<scnNodeSymbol>>();
			set => SetPropertyValue<CArray<scnNodeSymbol>>(value);
		}

		public scnDebugSymbols()
		{
			PerformersDebugSymbols = new();
			WorkspotsDebugSymbols = new();
			SceneEventsDebugSymbols = new();
			SceneNodesDebugSymbols = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
