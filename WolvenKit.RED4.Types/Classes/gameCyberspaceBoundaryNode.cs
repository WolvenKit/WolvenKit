using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCyberspaceBoundaryNode : worldTriggerAreaNode
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
	}
}
