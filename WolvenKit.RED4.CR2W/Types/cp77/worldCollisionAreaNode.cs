using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionAreaNode : worldAreaShapeNode
	{
		private CName _material;
		private NavGenNavigationSetting _navigationSetting;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(6)] 
		[RED("material")] 
		public CName Material
		{
			get
			{
				if (_material == null)
				{
					_material = (CName) CR2WTypeManager.Create("CName", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get
			{
				if (_navigationSetting == null)
				{
					_navigationSetting = (NavGenNavigationSetting) CR2WTypeManager.Create("NavGenNavigationSetting", "navigationSetting", cr2w, this);
				}
				return _navigationSetting;
			}
			set
			{
				if (_navigationSetting == value)
				{
					return;
				}
				_navigationSetting = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public worldCollisionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
