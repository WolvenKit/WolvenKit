using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NavGenNavigationSetting : RedBaseClass
	{
		private CEnum<NavGenNavmeshImpact> _navmeshImpact;

		[Ordinal(0)] 
		[RED("navmeshImpact")] 
		public CEnum<NavGenNavmeshImpact> NavmeshImpact
		{
			get => GetProperty(ref _navmeshImpact);
			set => SetProperty(ref _navmeshImpact, value);
		}

		public NavGenNavigationSetting()
		{
			_navmeshImpact = new() { Value = Enums.NavGenNavmeshImpact.Blocking };
		}
	}
}
