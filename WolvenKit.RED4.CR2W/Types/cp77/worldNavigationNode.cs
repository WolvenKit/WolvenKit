using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationNode : worldNode
	{
		private raRef<worldNavigationTileResource> _navigationTileResource;

		[Ordinal(4)] 
		[RED("navigationTileResource")] 
		public raRef<worldNavigationTileResource> NavigationTileResource
		{
			get
			{
				if (_navigationTileResource == null)
				{
					_navigationTileResource = (raRef<worldNavigationTileResource>) CR2WTypeManager.Create("raRef:worldNavigationTileResource", "navigationTileResource", cr2w, this);
				}
				return _navigationTileResource;
			}
			set
			{
				if (_navigationTileResource == value)
				{
					return;
				}
				_navigationTileResource = value;
				PropertySet(this);
			}
		}

		public worldNavigationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
