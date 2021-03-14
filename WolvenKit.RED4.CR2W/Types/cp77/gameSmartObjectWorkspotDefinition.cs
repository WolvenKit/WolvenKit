using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectWorkspotDefinition : gameSmartObjectDefinition
	{
		private rRef<workWorkspotResource> _workspotTemplate;

		[Ordinal(5)] 
		[RED("workspotTemplate")] 
		public rRef<workWorkspotResource> WorkspotTemplate
		{
			get
			{
				if (_workspotTemplate == null)
				{
					_workspotTemplate = (rRef<workWorkspotResource>) CR2WTypeManager.Create("rRef:workWorkspotResource", "workspotTemplate", cr2w, this);
				}
				return _workspotTemplate;
			}
			set
			{
				if (_workspotTemplate == value)
				{
					return;
				}
				_workspotTemplate = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
