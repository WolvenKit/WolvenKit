using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Container : animAnimNode_Base
	{
		private CArray<CHandle<animAnimNode_Base>> _nodes;

		[Ordinal(11)] 
		[RED("nodes")] 
		public CArray<CHandle<animAnimNode_Base>> Nodes
		{
			get
			{
				if (_nodes == null)
				{
					_nodes = (CArray<CHandle<animAnimNode_Base>>) CR2WTypeManager.Create("array:handle:animAnimNode_Base", "nodes", cr2w, this);
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

		public animAnimNode_Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
