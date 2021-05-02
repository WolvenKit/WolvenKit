using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseLink : CVariable
	{
		private wCHandle<animAnimNode_Base> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public wCHandle<animAnimNode_Base> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		public animPoseLink(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
