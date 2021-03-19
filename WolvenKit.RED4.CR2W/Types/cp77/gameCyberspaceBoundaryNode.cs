using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCyberspaceBoundaryNode : worldTriggerAreaNode
	{
		private NodeRef _marker1Ref;
		private NodeRef _marker2Ref;

		[Ordinal(7)] 
		[RED("marker1Ref")] 
		public NodeRef Marker1Ref
		{
			get => GetProperty(ref _marker1Ref);
			set => SetProperty(ref _marker1Ref, value);
		}

		[Ordinal(8)] 
		[RED("marker2Ref")] 
		public NodeRef Marker2Ref
		{
			get => GetProperty(ref _marker2Ref);
			set => SetProperty(ref _marker2Ref, value);
		}

		public gameCyberspaceBoundaryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
