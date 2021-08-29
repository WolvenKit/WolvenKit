using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckPathToCombatTarget : AIbehaviorconditionScript
	{
		private CHandle<worldNavigationScriptPath> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<worldNavigationScriptPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}
	}
}
