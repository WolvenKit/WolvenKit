using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animQuaternionLink : CVariable
	{
		private wCHandle<animAnimNode_QuaternionValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public wCHandle<animAnimNode_QuaternionValue> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		public animQuaternionLink(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
