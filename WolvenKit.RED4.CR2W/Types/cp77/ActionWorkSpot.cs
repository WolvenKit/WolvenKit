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
			get
			{
				if (_workspotTarget == null)
				{
					_workspotTarget = (wCHandle<gamePuppet>) CR2WTypeManager.Create("whandle:gamePuppet", "workspotTarget", cr2w, this);
				}
				return _workspotTarget;
			}
			set
			{
				if (_workspotTarget == value)
				{
					return;
				}
				_workspotTarget = value;
				PropertySet(this);
			}
		}

		public ActionWorkSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
