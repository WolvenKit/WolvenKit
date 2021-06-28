using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapData : IScriptable
	{
		private CEnum<gamedataWorkspotActionType> _action;
		private CArray<CHandle<WorkspotEntryData>> _workspots;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("workspots")] 
		public CArray<CHandle<WorkspotEntryData>> Workspots
		{
			get => GetProperty(ref _workspots);
			set => SetProperty(ref _workspots, value);
		}

		public WorkspotMapData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
