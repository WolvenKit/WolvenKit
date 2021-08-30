using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_WorkspotAnim : animAnimNode_Base
	{
		private CBool _collectEvents;
		private animPoseLink _inputLink;

		[Ordinal(11)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get => GetProperty(ref _collectEvents);
			set => SetProperty(ref _collectEvents, value);
		}

		[Ordinal(12)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetProperty(ref _inputLink);
			set => SetProperty(ref _inputLink, value);
		}

		public animAnimNode_WorkspotAnim()
		{
			_collectEvents = true;
		}
	}
}
