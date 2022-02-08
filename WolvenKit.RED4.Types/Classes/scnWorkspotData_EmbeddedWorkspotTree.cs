using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnWorkspotData_EmbeddedWorkspotTree : scnWorkspotData
	{
		[Ordinal(1)] 
		[RED("workspotTree")] 
		public CHandle<workWorkspotTree> WorkspotTree
		{
			get => GetPropertyValue<CHandle<workWorkspotTree>>();
			set => SetPropertyValue<CHandle<workWorkspotTree>>(value);
		}

		public scnWorkspotData_EmbeddedWorkspotTree()
		{
			DataId = new() { Id = 4294967295 };
		}
	}
}
