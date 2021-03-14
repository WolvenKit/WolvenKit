using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NavGenNavigationSetting : CVariable
	{
		private CEnum<NavGenNavmeshImpact> _navmeshImpact;

		[Ordinal(0)] 
		[RED("navmeshImpact")] 
		public CEnum<NavGenNavmeshImpact> NavmeshImpact
		{
			get
			{
				if (_navmeshImpact == null)
				{
					_navmeshImpact = (CEnum<NavGenNavmeshImpact>) CR2WTypeManager.Create("NavGenNavmeshImpact", "navmeshImpact", cr2w, this);
				}
				return _navmeshImpact;
			}
			set
			{
				if (_navmeshImpact == value)
				{
					return;
				}
				_navmeshImpact = value;
				PropertySet(this);
			}
		}

		public NavGenNavigationSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
