using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotData_EmbeddedWorkspotTree : scnWorkspotData
	{
		private CHandle<workWorkspotTree> _workspotTree;

		[Ordinal(1)] 
		[RED("workspotTree")] 
		public CHandle<workWorkspotTree> WorkspotTree
		{
			get => GetProperty(ref _workspotTree);
			set => SetProperty(ref _workspotTree, value);
		}

		public scnWorkspotData_EmbeddedWorkspotTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
