using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCLinkedLayersDefinition : gameinteractionsNodeDefinition
	{
		private CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> _layersDefinitions;
		private CHandle<gameinteractionsvisIVisualizerDefinition> _visualizerDefinition;
		private CName _tag;

		[Ordinal(0)] 
		[RED("layersDefinitions")] 
		public CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> LayersDefinitions
		{
			get => GetProperty(ref _layersDefinitions);
			set => SetProperty(ref _layersDefinitions, value);
		}

		[Ordinal(1)] 
		[RED("visualizerDefinition")] 
		public CHandle<gameinteractionsvisIVisualizerDefinition> VisualizerDefinition
		{
			get => GetProperty(ref _visualizerDefinition);
			set => SetProperty(ref _visualizerDefinition, value);
		}

		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		public gameinteractionsCLinkedLayersDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
