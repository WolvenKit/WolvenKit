using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		private raRef<entEntityTemplate> _viewTemplate;
		private rRef<worldEnvironmentAreaParameters> _viewEnvironmentDefinition;
		private raRef<entEntityTemplate> _cursorTemplate;

		[Ordinal(3)] 
		[RED("viewTemplate")] 
		public raRef<entEntityTemplate> ViewTemplate
		{
			get
			{
				if (_viewTemplate == null)
				{
					_viewTemplate = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "viewTemplate", cr2w, this);
				}
				return _viewTemplate;
			}
			set
			{
				if (_viewTemplate == value)
				{
					return;
				}
				_viewTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("viewEnvironmentDefinition")] 
		public rRef<worldEnvironmentAreaParameters> ViewEnvironmentDefinition
		{
			get
			{
				if (_viewEnvironmentDefinition == null)
				{
					_viewEnvironmentDefinition = (rRef<worldEnvironmentAreaParameters>) CR2WTypeManager.Create("rRef:worldEnvironmentAreaParameters", "viewEnvironmentDefinition", cr2w, this);
				}
				return _viewEnvironmentDefinition;
			}
			set
			{
				if (_viewEnvironmentDefinition == value)
				{
					return;
				}
				_viewEnvironmentDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cursorTemplate")] 
		public raRef<entEntityTemplate> CursorTemplate
		{
			get
			{
				if (_cursorTemplate == null)
				{
					_cursorTemplate = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "cursorTemplate", cr2w, this);
				}
				return _cursorTemplate;
			}
			set
			{
				if (_cursorTemplate == value)
				{
					return;
				}
				_cursorTemplate = value;
				PropertySet(this);
			}
		}

		public gameuiWorldMapPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
