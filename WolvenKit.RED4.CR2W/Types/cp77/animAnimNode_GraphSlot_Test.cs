using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlot_Test : animAnimNode_GraphSlot
	{
		private rRef<animAnimGraph> _graph_TEST;

		[Ordinal(14)] 
		[RED("graph_TEST")] 
		public rRef<animAnimGraph> Graph_TEST
		{
			get
			{
				if (_graph_TEST == null)
				{
					_graph_TEST = (rRef<animAnimGraph>) CR2WTypeManager.Create("rRef:animAnimGraph", "graph_TEST", cr2w, this);
				}
				return _graph_TEST;
			}
			set
			{
				if (_graph_TEST == value)
				{
					return;
				}
				_graph_TEST = value;
				PropertySet(this);
			}
		}

		public animAnimNode_GraphSlot_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
