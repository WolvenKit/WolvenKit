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
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}

		public animAnimGraphDebugState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
