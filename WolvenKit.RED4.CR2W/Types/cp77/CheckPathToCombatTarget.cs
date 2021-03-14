using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckPathToCombatTarget : AIbehaviorconditionScript
	{
		private CHandle<worldNavigationScriptPath> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<worldNavigationScriptPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<worldNavigationScriptPath>) CR2WTypeManager.Create("handle:worldNavigationScriptPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		public CheckPathToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
