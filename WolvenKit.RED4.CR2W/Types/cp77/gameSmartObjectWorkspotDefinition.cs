using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectWorkspotDefinition : gameSmartObjectDefinition
	{
		[Ordinal(5)] [RED("workspotTemplate")] public rRef<workWorkspotResource> WorkspotTemplate { get; set; }

		public gameSmartObjectWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
