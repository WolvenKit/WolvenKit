using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectWorkspotDefinition : gameSmartObjectDefinition
	{
		private rRef<workWorkspotResource> _workspotTemplate;

		[Ordinal(5)] 
		[RED("workspotTemplate")] 
		public rRef<workWorkspotResource> WorkspotTemplate
		{
			get => GetProperty(ref _workspotTemplate);
			set => SetProperty(ref _workspotTemplate, value);
		}

		public gameSmartObjectWorkspotDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
