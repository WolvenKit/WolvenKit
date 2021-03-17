using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrafficExternalWorkspotDefinition : worldTrafficSpotDefinition
	{
		private CBool _nearestPointEntry;
		private NodeRef _globalWorkspotNodeRef;

		[Ordinal(2)] 
		[RED("nearestPointEntry")] 
		public CBool NearestPointEntry
		{
			get => GetProperty(ref _nearestPointEntry);
			set => SetProperty(ref _nearestPointEntry, value);
		}

		[Ordinal(3)] 
		[RED("globalWorkspotNodeRef")] 
		public NodeRef GlobalWorkspotNodeRef
		{
			get => GetProperty(ref _globalWorkspotNodeRef);
			set => SetProperty(ref _globalWorkspotNodeRef, value);
		}

		public AITrafficExternalWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
