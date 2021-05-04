using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionWorkSpot : ActionBool
	{
		private wCHandle<gamePuppet> _workspotTarget;

		[Ordinal(25)] 
		[RED("workspotTarget")] 
		public wCHandle<gamePuppet> WorkspotTarget
		{
			get => GetProperty(ref _workspotTarget);
			set => SetProperty(ref _workspotTarget, value);
		}

		public ActionWorkSpot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
