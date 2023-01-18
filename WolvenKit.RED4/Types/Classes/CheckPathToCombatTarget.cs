using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckPathToCombatTarget : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<worldNavigationScriptPath> Path
		{
			get => GetPropertyValue<CHandle<worldNavigationScriptPath>>();
			set => SetPropertyValue<CHandle<worldNavigationScriptPath>>(value);
		}

		public CheckPathToCombatTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
