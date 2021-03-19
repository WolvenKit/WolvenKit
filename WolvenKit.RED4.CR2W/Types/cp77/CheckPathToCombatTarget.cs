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
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		public CheckPathToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
