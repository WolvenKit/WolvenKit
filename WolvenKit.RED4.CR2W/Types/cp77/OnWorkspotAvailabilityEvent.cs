using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnWorkspotAvailabilityEvent : redEvent
	{
		private NodeRef _workspotRef;

		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get
			{
				if (_workspotRef == null)
				{
					_workspotRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "workspotRef", cr2w, this);
				}
				return _workspotRef;
			}
			set
			{
				if (_workspotRef == value)
				{
					return;
				}
				_workspotRef = value;
				PropertySet(this);
			}
		}

		public OnWorkspotAvailabilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
