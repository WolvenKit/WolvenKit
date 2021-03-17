using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animBoolLink : CVariable
	{
		private wCHandle<animAnimNode_BoolValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public wCHandle<animAnimNode_BoolValue> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		public animBoolLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
