using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphResource : CResource
	{
		private CHandle<graphGraphDefinition> _graph;

		[Ordinal(1)] 
		[RED("graph")] 
		public CHandle<graphGraphDefinition> Graph
		{
			get => GetProperty(ref _graph);
			set => SetProperty(ref _graph, value);
		}

		public graphGraphResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
