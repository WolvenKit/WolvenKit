using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReserveWorkSpotTask : WorkSpotTask
	{
		private NodeRef _workspotRef;
		private wCHandle<gameObject> _workspotObject;

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

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public wCHandle<gameObject> WorkspotObject
		{
			get
			{
				if (_workspotObject == null)
				{
					_workspotObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "workspotObject", cr2w, this);
				}
				return _workspotObject;
			}
			set
			{
				if (_workspotObject == value)
				{
					return;
				}
				_workspotObject = value;
				PropertySet(this);
			}
		}

		public ReserveWorkSpotTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
