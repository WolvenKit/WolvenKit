using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WorkspotAnim : animAnimNode_Base
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

		public animAnimNode_WorkspotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
