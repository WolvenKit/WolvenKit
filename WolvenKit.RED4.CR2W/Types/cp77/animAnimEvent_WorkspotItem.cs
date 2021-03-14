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
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<CHandle<workIWorkspotItemAction>>) CR2WTypeManager.Create("array:handle:workIWorkspotItemAction", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_WorkspotItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
