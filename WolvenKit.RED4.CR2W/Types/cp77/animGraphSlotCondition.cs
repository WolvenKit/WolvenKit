using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGraphSlotCondition : CVariable
	{
		private CHandle<animIStaticCondition> _condition;
		private rRef<animAnimGraph> _graph;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<animIStaticCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<animIStaticCondition>) CR2WTypeManager.Create("handle:animIStaticCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("graph")] 
		public rRef<animAnimGraph> Graph
		{
			get
			{
				if (_graph == null)
				{
					_graph = (rRef<animAnimGraph>) CR2WTypeManager.Create("rRef:animAnimGraph", "graph", cr2w, this);
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

		public animGraphSlotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
