using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphDefinition : graphIGraphObjectDefinition
	{
		private CArray<CHandle<graphGraphNodeDefinition>> _nodes;

		[Ordinal(0)] 
		[RED("nodes")] 
		public CArray<CHandle<graphGraphNodeDefinition>> Nodes
		{
			get
			{
				if (_nodes == null)
				{
					_nodes = (CArray<CHandle<graphGraphNodeDefinition>>) CR2WTypeManager.Create("array:handle:graphGraphNodeDefinition", "nodes", cr2w, this);
				}
				return _nodes;
			}
			set
			{
				if (_nodes == value)
				{
					return;
				}
				_nodes = value;
				PropertySet(this);
			}
		}

		public graphGraphDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
