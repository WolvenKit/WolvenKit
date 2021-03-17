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
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}

		public animAnimNode_Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
