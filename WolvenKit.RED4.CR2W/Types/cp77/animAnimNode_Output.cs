using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Output : animAnimNode_Base
	{
		private animPoseLink _node;

		[Ordinal(11)] 
		[RED("node")] 
		public animPoseLink Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		public animAnimNode_Output(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
