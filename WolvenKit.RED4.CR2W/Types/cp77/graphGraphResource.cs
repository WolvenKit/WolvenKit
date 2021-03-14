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
			get
			{
				if (_graph == null)
				{
					_graph = (CHandle<graphGraphDefinition>) CR2WTypeManager.Create("handle:graphGraphDefinition", "graph", cr2w, this);
				}
				return _graph;
			}
			set
			{
				if (_graph == value)
				{
					return;
				}
				_graph = value;
				PropertySet(this);
			}
		}

		public graphGraphResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
