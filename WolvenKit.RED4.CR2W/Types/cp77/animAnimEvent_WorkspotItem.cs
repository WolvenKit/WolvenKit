using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_WorkspotItem : animAnimEvent
	{
		private CArray<CHandle<workIWorkspotItemAction>> _actions;

		[Ordinal(3)] 
		[RED("actions")] 
		public CArray<CHandle<workIWorkspotItemAction>> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}

		public animAnimEvent_WorkspotItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
