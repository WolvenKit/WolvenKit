using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotData_ExternalWorkspotResource : scnWorkspotData
	{
		[Ordinal(0)]  [RED("workspotResource")] public rRef<workWorkspotResource> WorkspotResource { get; set; }

		public scnWorkspotData_ExternalWorkspotResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
