using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrafficWorkspotDefinition : worldTrafficSpotDefinition
	{
		private rRef<workWorkspotResource> _workspotResource;

		[Ordinal(2)] 
		[RED("workspotResource")] 
		public rRef<workWorkspotResource> WorkspotResource
		{
			get => GetProperty(ref _workspotResource);
			set => SetProperty(ref _workspotResource, value);
		}

		public AITrafficWorkspotDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
