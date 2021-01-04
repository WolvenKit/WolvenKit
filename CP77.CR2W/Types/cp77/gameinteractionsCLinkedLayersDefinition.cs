using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCLinkedLayersDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)]  [RED("layersDefinitions")] public CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> LayersDefinitions { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)]  [RED("visualizerDefinition")] public CHandle<gameinteractionsvisIVisualizerDefinition> VisualizerDefinition { get; set; }

		public gameinteractionsCLinkedLayersDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
