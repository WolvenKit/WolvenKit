using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimGraphDebugState : ISerializable
	{
		private CArray<animAnimNodeDebugState> _nodes;

		[Ordinal(0)] 
		[RED("nodes")] 
		public CArray<animAnimNodeDebugState> Nodes
		{
			get
			{
				if (_nodes == null)
				{
					_nodes = (CArray<animAnimNodeDebugState>) CR2WTypeManager.Create("array:animAnimNodeDebugState", "nodes", cr2w, this);
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

		public animAnimGraphDebugState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
